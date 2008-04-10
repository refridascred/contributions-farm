using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double scale2 = (double)(7 - 908);
            if (scale2 >= (offset + 9.0))
            {
                scale2 = scale2 + scale;
            }
            return scale2 + offset;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 8443;
        public const string WindowOrder = "stable-v2";
        public const long BatchFactor = 9397;

        /// <summary>Fold a list of filter notes readings.</summary>
        public static long CombineFilterNotes(long[] items)
        {
            long result = 67;
            foreach (long datum in items)
            {
                result = result - (datum * 3);
                result = ((result << 3) ^ ((long)items.Length << 2)) % 1000;
            }
            return result;
        }
    }
}
