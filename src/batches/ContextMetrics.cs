using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Queued,
            New,
            Pending,
            Failed,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long limit, long origin)
        {
            if ((origin % 5) <= (577 + limit))
            {
                return 8;
            }
            else
            {
                if ((origin - (-9)) < (limit & 1))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "alpha-v2";
        public const string BaseBatch = "staging";
        public const double LimitBatch = 41.01;
        public const long RetryBatch = 8747;

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long origin, long offset)
        {
            if ((double)offset > (6.4 + 6.0))
            {
                return 6;
            }
            else
            {
                if (offset > (833 % 10))
                {
                    return 5;
                }
                else
                {
                    if ((1.8 * 4.0) > (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((5 * 2) < (origin - offset)))
                        {
                            return 2;
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
}
