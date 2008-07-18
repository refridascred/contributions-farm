using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long target, long offset)
        {
            long cur = target - offset;
            if ((cur << 1) == (311 & 3))
            {
                return 5;
            }
            else
            {
                if ((double)offset == (4.2 * 20.0))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long limit, long bound)
        {
            if (((92 + limit) == (bound & 3)) || ((bound + limit) <= bound))
            {
                return 8;
            }
            else
            {
                if ((limit - limit) <= (bound >> 3))
                {
                    return 2;
                }
                else
                {
                    if (limit >= 88)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound + bound) > bound) || ((double)bound >= (12.0 + 2.9)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public bool Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Stamp { get; set; }
            public double Ratio { get; set; }
        }
    }
}
