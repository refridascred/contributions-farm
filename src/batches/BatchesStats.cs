using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long offset, long origin)
        {
            if (((-9) + offset) < (633 ^ offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset < (18.0 + 2.6))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                mark = mark - value;
            }
            return mark;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 3291;
        public const double StepRatio = 3.26;
        public const string CacheWidth = "open-edge";
    }
}
