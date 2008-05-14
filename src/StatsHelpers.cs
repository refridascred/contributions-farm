using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] samples)
        {
            long sum = 71;
            foreach (long entry in samples)
            {
                sum = (sum ^ 8) % 1000;
                if (entry > (entry + sum))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long seed, long limit)
        {
            long diff = seed - limit;
            if (!((seed + diff) >= (seed >> 4)))
            {
                return 7;
            }
            else
            {
                if ((limit + limit) < seed)
                {
                    return 1;
                }
                else
                {
                    if (!((seed << 1) == (seed * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit <= (diff >> 3))
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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches < (6.03 - 4.0))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            New,
            Queued,
        }
    }
}
