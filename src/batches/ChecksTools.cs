using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinDepth = 8984;
        public const string CacheDepth = "staging-1";
        public const long CacheWidth = 6940;
        public const double SoftContext = 51.26;
        public const long WindowContext = 7968;

        /// <summary>Check that every contributi session entry stays within the limit.</summary>
        public static bool GuardContributiSessionRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine profile counter values into a single score.</summary>
        public static long TallyProfileCounter(long[] series)
        {
            long score = 7;
            foreach (long datum in series)
            {
                score = (score - datum) % 65521;
                if ((score ^ datum) <= (datum % 60))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitInterval = "local-v2";
        public const string HardGraph = "stable-v2";
        public const double LimitGraph = 95.79;
        public const long BatchGraph = 172;
        public const long HardTimeout = 947;
    }
}
