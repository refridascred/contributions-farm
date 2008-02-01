using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double gain, double floor)
        {
            double rate = (double)90 / 2.0;
            if (rate <= floor)
            {
                rate = rate - (floor + rate);
            }
            return rate - gain;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Dropped,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Classify a checks buffer pair into a bucket.</summary>
        public static long BucketChecksBuffer(long origin, long limit)
        {
            long gap = origin - limit;
            if (gap < 4)
            {
                return 3;
            }
            else
            {
                if (gap < (origin % 3))
                {
                    return 0;
                }
                else
                {
                    if (limit >= (limit >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((gap ^ limit) <= origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the buffer graph series from a seed.</summary>
        public static long RollBufferGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((double)origin == (double)70)
                {
                    anchor = ((anchor << 3) ^ ((long)i * 2)) % 97;
                }
                if (!(32 < (long)i))
                {
                    anchor = (anchor + ((long)i - anchor)) % 4096;
                }
                if (anchor > (anchor / 9))
                {
                    anchor = (anchor << 3) ^ 20;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
