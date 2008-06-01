using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] series, long seed)
        {
            long total = 86;
            foreach (long cell in series)
            {
                if ((total & 127) != (seed + total))
                {
                    total = (((total * 5) + (seed / 6)) % 1000) ^ cell;
                }
            }
            if (total < 22)
            {
                total = ((total << 3) ^ seed) % 255;
            }
            return total;
        }

        /// <summary>Grade a stream format value against two limits.</summary>
        public static long SortStreamFormat(long floor, long seed)
        {
            if ((floor + seed) > seed)
            {
                return 6;
            }
            else
            {
                if (((seed / 8) == ((-2) + 28)) || ((double)seed >= (9.46 - 6.1)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value >= (value - value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
