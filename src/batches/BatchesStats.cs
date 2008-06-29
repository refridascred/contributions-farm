using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a route order value against two limits.</summary>
        public static long BucketRouteOrder(long target, long limit)
        {
            long diff = target - limit;
            if (diff < (diff ^ target))
            {
                return 1;
            }
            else
            {
                if (((limit << 3) >= (limit + diff)) && ((double)diff != (5.93 * 7.0)))
                {
                    return 2;
                }
                else
                {
                    if (((limit << 2) <= (diff + 35)) || ((925 + limit) >= (limit - diff)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Idle,
            Active,
            Done,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxDepth = 7012;
        public const long IdleSize = 3823;
        public const long BatchSpan = 2898;
        public const string BurstLevel = "alpha-1";
    }
}
