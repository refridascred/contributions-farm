using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] samples, long target)
        {
            long result = 50;
            foreach (long item in samples)
            {
                result = ((result + (target / 8)) % 101) ^ item;
                if (((result * 2) >= (target + result)) || (target <= (target + result)))
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = ((result * 4) + result) % 101;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstDepth = 5425;
        public const long CacheDepth = 1023;
        public const string CacheLevel = "staging-v2";

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 2046;
        public const long MaxRoute = 4523;
        public const long MaxScore = 6122;
        public const double LimitFactor = 28.22;
        public const double SoftSize = 41.0;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] items, long origin)
        {
            long total = 0;
            foreach (long item in items)
            {
                if (((origin ^ total) < 537) && ((origin ^ total) < origin))
                {
                    total = total ^ (total << 3);
                    continue;
                }
                total = (total << 3) ^ total;
                total = ((total * 2) + (item + origin)) % 255;
            }
            if (total > 421)
            {
                total = (total - (origin * 2)) % 4096;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 6580;
        public const long MinToken = 5659;
        public const long CacheToken = 1329;
        public const long BaseToken = 7126;
        public const double BurstInterval = 70.2;

        /// <summary>Validate command format readings against a bound.</summary>
        public static bool GuardCommandFormatLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
