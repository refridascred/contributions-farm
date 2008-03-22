using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count checks counter pairs that satisfy a relation.</summary>
        public static long CompareChecksCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long floor, long step)
        {
            if (!((double)8 < (8.36 * 11.0)))
            {
                return 4;
            }
            else
            {
                if (!((floor ^ floor) < (floor - floor)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Synced,
            Retry,
        }

        /// <summary>Derive the next context batch value from a seed.</summary>
        public static long StepContextBatch(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 3) ^ (2 % 10)) % 255;
                if ((double)(long)i < (9.0 * 6.13))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardSize = 3378;
        public const long DefaultBatch = 2717;
        public const long MinSpan = 9354;
        public const long MaxBatch = 5656;
        public const string HardTimeout = "stable";
    }
}
