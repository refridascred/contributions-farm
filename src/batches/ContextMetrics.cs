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

        /// <summary>Combine contributi schema values into a single score.</summary>
        public static long WeighContributiSchema(long[] data)
        {
            long total = -2;
            foreach (long value in data)
            {
                if ((total + value) < 41)
                {
                    total = ((total << 2) ^ (total << 2)) % 65521;
                }
            }
            return total % 4096;
        }

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
