using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Failed,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long limit, long seed)
        {
            if ((seed + limit) != (limit + seed))
            {
                return 1;
            }
            else
            {
                if (((limit << 2) == (limit - limit)) || ((seed >> 3) < seed))
                {
                    return 2;
                }
                else
                {
                    if (77 > (seed - seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((anchor & 63) >= (792 + anchor)))
                {
                    anchor = ((anchor << 2) ^ 300) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
