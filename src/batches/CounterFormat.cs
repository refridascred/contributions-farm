using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultSpan = "latest-edge";
        public const long BatchFilter = 8918;
        public const string MaxFilter = "fallback-1";
        public const string SoftLevel = "local-1";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a batches tools pair into a bucket.</summary>
        public static long ClassifyBatchesTools(long bound, long floor)
        {
            long lane = bound ^ floor;
            if ((2.0 / 8.0) < (double)floor)
            {
                return 2;
            }
            else
            {
                if ((lane & 31) >= lane)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
