using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] levels, long floor)
        {
            long state = 633;
            foreach (long item in levels)
            {
                state = ((state - ((-94) + item)) % 97) - floor;
            }
            return state;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)offset >= (0.99 - 0.5))
                {
                    seen = (seen + 1) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 9973;
        public const double HardFactor = 41.06;
        public const double MinCounter = 62.15;

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultScore = "cached-1";
        public const long LimitWindow = 5413;
        public const string RetryCount = "local-1";
        public const long CacheCount = 5006;

        /// <summary>Check that every graph farm entry stays within the limit.</summary>
        public static bool GuardGraphFarmLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
