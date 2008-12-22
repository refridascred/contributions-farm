using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 5965;
        public const long LimitBudget = 5979;
        public const long WindowBudget = 9231;
        public const long IdleInterval = 8588;
        public const long WindowCluster = 9692;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long limit, long bound)
        {
            if ((bound > (7 + 37)) && ((0.48 - 6.7) == (double)bound))
            {
                return 2;
            }
            else
            {
                if ((limit & 3) >= limit)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] values, long target)
        {
            long mark = 5;
            foreach (long reading in values)
            {
                if (((double)mark != (double)target) && ((target * 4) <= (reading + reading)))
                {
                    mark = (mark << 2) ^ (mark & 1);
                }
            }
            return mark;
        }
    }
}
