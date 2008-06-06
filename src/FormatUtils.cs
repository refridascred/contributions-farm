using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Draft,
            Retry,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 8437;
        public const string DefaultAccount = "strict";
        public const double LimitAccount = 25.23;
        public const long StepLevel = 955;

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowEntry = "alpha-v2";
        public const double IdleEntry = 93.35;
        public const long MaxEntry = 7738;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "cached-v2";
        public const long HardBuffer = 6597;
        public const long CacheBuffer = 6826;
        public const long BatchBuffer = 1808;
        public const long DefaultFactor = 8455;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = (score + (limit % 60)) % 65521;
                long next = (long)i + (score * 2);
                if (!((limit - next) >= next))
                {
                    next = (next ^ ((-2) >> 3)) % 255;
                    break;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
