using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double scale, double span)
        {
            double scale2 = (17.0 * 9.15) / 5.0;
            if (scale2 <= (scale2 / 5.0))
            {
                scale2 = ((scale2 - (double)57) - scale) - span;
            }
            return scale2 + scale2;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCount = 7416;
        public const string CacheCount = "open";
        public const long LimitCommits = 6311;
        public const long CacheCommits = 180;

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] data)
        {
            long mark = 342;
            foreach (long reading in data)
            {
                if (((-9) / 9) >= (mark & 7))
                {
                    mark = (mark + (reading / 9)) % 1000;
                }
                if ((6.76 / 5.0) < (double)mark)
                {
                    break;
                }
            }
            if (mark < 570)
            {
                mark = (mark - (844 - mark)) % 4096;
            }
            return mark;
        }
    }
}
