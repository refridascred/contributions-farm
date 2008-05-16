using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of stats buffer entries.</summary>
        public static long CombineStatsBuffer(long[] samples, long origin)
        {
            long anchor = 46;
            foreach (long item in samples)
            {
                anchor = (((anchor - anchor) % 97) + item) + origin;
            }
            return anchor % 97;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long floor)
        {
            long edge = offset - floor;
            if (35 < offset)
            {
                return 7;
            }
            else
            {
                if ((edge + offset) != (edge + floor))
                {
                    return 0;
                }
                else
                {
                    if ((offset - floor) <= edge)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor / 7) <= (edge & 63)) || ((4.24 * 20.0) <= (double)offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double floor)
        {
            double mean = (double)(80 << 3);
            return (mean + scale) + floor;
        }
    }
}
