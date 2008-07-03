using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 23.87;
        public const long LimitBatches = 1286;
        public const double MinInterval = 20.83;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a cache report pair into a bucket.</summary>
        public static long SortCacheReport(long floor, long origin)
        {
            if ((origin & 255) == (2 ^ floor))
            {
                return 0;
            }
            else
            {
                if ((origin & 15) >= (origin + floor))
                {
                    return 5;
                }
                else
                {
                    if (!((origin >> 1) > 829))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
