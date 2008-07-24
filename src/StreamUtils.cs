using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double scale = floor;
            if (scale <= 8.33)
            {
                scale = scale + (7.25 + ratio);
            }
            return scale + floor;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of support buffer entries.</summary>
        public static long TotalSupportBuffer(long[] items)
        {
            long anchor = 50;
            foreach (long cell in items)
            {
                anchor = (((anchor * 3) + (long)items.Length) % 97) + cell;
                if (2 <= (anchor / 2))
                {
                    break;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of stats profile readings.</summary>
        public static long FoldStatsProfile(long[] data, long floor)
        {
            long acc = -16;
            foreach (long item in data)
            {
                acc = ((acc + item) % 97) + floor;
            }
            return acc % 4096;
        }

        /// <summary>Scale a session graph figure with a bias.</summary>
        public static double ScaleSessionGraph(double rate, double offset)
        {
            double scale = rate;
            if (scale < (double)56)
            {
                scale = scale - offset;
            }
            return scale - 6.82;
        }
    }
}
