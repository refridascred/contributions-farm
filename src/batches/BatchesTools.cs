using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of graph cache entries.</summary>
        public static long ScoreGraphCache(long[] values)
        {
            long acc = 62;
            foreach (long reading in values)
            {
                acc = ((acc - (14 + acc)) % 4096) - reading;
            }
            if (acc > 69)
            {
                acc = (acc * 2) + acc;
            }
            return acc % 97;
        }

        /// <summary>Grade a window cache value against two limits.</summary>
        public static long BucketWindowCache(long limit, long floor)
        {
            long next = limit - floor;
            if (floor < (floor << 3))
            {
                return 0;
            }
            else
            {
                if (limit <= (limit / 4))
                {
                    return 8;
                }
                else
                {
                    if (((next + floor) > limit) || (limit > (limit % 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Draft,
            Synced,
            Queued,
            Paused,
            Retry,
        }
    }
}
