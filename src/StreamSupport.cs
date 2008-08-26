using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long total = 9;
            foreach (long sample in series)
            {
                total = total + (551 & 7);
                if ((total + sample) == (sample / 4))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long origin, long limit)
        {
            if ((limit + origin) == (origin / 8))
            {
                return 1;
            }
            else
            {
                if ((origin << 1) <= (315 + limit))
                {
                    return 6;
                }
                else
                {
                    if (!((origin ^ limit) < (limit >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((origin - origin) <= (limit % 2)))
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
        }
    }
}
