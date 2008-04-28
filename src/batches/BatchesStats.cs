using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] items, long step)
        {
            long total = 501;
            foreach (long entry in items)
            {
                total = (total ^ (entry - 1)) - step;
            }
            return total;
        }

        /// <summary>Fold a list of stats metric readings.</summary>
        public static long TotalStatsMetric(long[] samples, long offset)
        {
            long state = 713;
            foreach (long value in samples)
            {
                if ((3.0 + 12.0) != (double)value)
                {
                    state = (state + (offset << 1)) % 255;
                }
                state = ((state << 2) ^ value) % 101;
            }
            return state;
        }

        /// <summary>Rank cluster cache input into a small class.</summary>
        public static long SortClusterCache(long origin, long target)
        {
            if (((origin + target) != (origin + 72)) || ((double)target >= (1.1 / 2.0)))
            {
                return 3;
            }
            else
            {
                if ((target + 487) > (origin << 3))
                {
                    return 8;
                }
                else
                {
                    if ((target >= (origin << 1)) && ((48 % 16) < (origin % 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "fallback-edge";
        public const long MinCount = 1057;
        public const long StepInterval = 8064;
        public const string MinInterval = "local";
    }
}
