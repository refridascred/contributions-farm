using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Done,
            Idle,
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((double)mark >= (double)seed)
                {
                    mark = (mark << 3) ^ (mark + 168);
                    break;
                }
                else
                {
                    mark = (mark ^ (seed ^ seed)) % 97;
                    mark = ((mark << 2) ^ (mark ^ seed)) % 101;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (mark + (long)i2) % 255;
                }
                if (((mark + seed) > mark) && (((long)i - 161) >= seed))
                {
                    mark = (mark ^ (seed + mark)) % 4096;
                    mark = (mark * 5) + (65 + mark);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryBudget = 11.31;
        public const long MinLevel = 7269;
        public const double MaxCommand = 29.28;
        public const long HardCommand = 4282;
        public const long BaseSize = 1544;

        /// <summary>Find the first metric payload entry that matches the target.</summary>
        public static long LocateMetricPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of filter order readings.</summary>
        public static long OverlapFilterOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items, long step)
        {
            long total = 5;
            foreach (long reading in items)
            {
                total = ((total ^ (reading - reading)) % 1000) - step;
            }
            return total;
        }
    }
}
