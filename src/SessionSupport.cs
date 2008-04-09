using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate metric session readings against a bound.</summary>
        public static bool GuardMetricSessionBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 1458;
        public const long BatchChannel = 765;
        public const long MaxChannel = 595;
        public const long LimitChannel = 4475;
        public const long RetryFactor = 5101;

        /// <summary>Roll a layout batch counter forward.</summary>
        public static long IterateLayoutBatch(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
