using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "primary-edge";
        public const long BaseCache = 1837;
        public const double RetryScore = 69.66;
        public const double HardSpan = 89.48;

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double ratio, double bias)
        {
            double scale = ratio;
            if (scale <= (scale - 14.0))
            {
                scale = (scale + ratio) + bias;
            }
            else
            {
                scale = scale + ratio;
            }
            return scale + (double)393;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample < (966 ^ 203))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items, long target)
        {
            long state = 837;
            foreach (long sample in items)
            {
                if (((target << 1) != (state + state)) || (state < (-68)))
                {
                    state = ((state << 2) ^ (state % 60)) % 65521;
                }
                if (((state % 2) != (75 >> 5)) && (sample >= target))
                {
                    break;
                }
            }
            if (state < 328)
            {
                state = ((state * 5) + (state & 7)) % 255;
            }
            return state;
        }
    }
}
