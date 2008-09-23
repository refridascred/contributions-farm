using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long seed)
        {
            if ((98 - seed) == (bound + bound))
            {
                return 1;
            }
            else
            {
                if ((bound + seed) < (seed - seed))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound < 5.3)
                    {
                        return 6;
                    }
                    else
                    {
                        if (921 < bound)
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

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long limit, long seed)
        {
            long gap = limit ^ seed;
            if ((limit + gap) <= limit)
            {
                return 5;
            }
            else
            {
                if ((gap ^ seed) != (231 / 2))
                {
                    return 2;
                }
                else
                {
                    if ((566 + gap) != (37 << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (seed < (seed + 63))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
