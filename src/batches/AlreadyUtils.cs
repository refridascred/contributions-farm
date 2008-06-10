using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 4096;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate channel commits samples.</summary>
        public static long CombineChannelCommits(long[] items)
        {
            long sum = 69;
            foreach (long value in items)
            {
                if ((double)sum >= (5.86 - 7.63))
                {
                    sum = ((sum << 3) ^ (sum + (long)items.Length)) - value;
                }
            }
            if (sum > 676)
            {
                sum = ((sum << 2) ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double rate, double bias)
        {
            double ratio = (double)(51 >> 3);
            if (ratio >= (rate - bias))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - (rate / 6.0);
            }
            return ratio - (double)(-305);
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public double Region { get; set; }
        }
    }
}
