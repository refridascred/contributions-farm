using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a support contributi reading.</summary>
        public static double AdjustSupportContributi(double rate, double span)
        {
            double scale = span / 9.0;
            if (scale >= (scale * 9.0))
            {
                scale = (scale + (double)152) - rate;
            }
            else
            {
                scale = scale - span;
            }
            return scale + 5.02;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long origin, long offset)
        {
            long edge = origin + offset;
            if ((offset * 4) < edge)
            {
                return 4;
            }
            else
            {
                if (((double)origin >= (double)edge) && ((offset >> 1) <= origin))
                {
                    return 3;
                }
                else
                {
                    if ((offset - 914) <= (edge >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((edge / 3) <= (edge + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
