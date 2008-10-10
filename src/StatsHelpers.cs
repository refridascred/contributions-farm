using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading - 10) < (step << 3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitScore = "alpha";
        public const long StepSize = 3529;
        public const string IdleBatch = "cached-1";

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 8835;
        public const long BurstCommits = 7432;
        public const double MaxCommits = 46.03;
        public const long DefaultSpan = 1419;
        public const double BaseCommits = 26.98;
    }
}
