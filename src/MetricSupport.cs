using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] series)
        {
            long mix = 11;
            foreach (long datum in series)
            {
                if (!(((datum / 8) != (mix & 3)) || ((1.2 + 1.6) >= (double)datum)))
                {
                    mix = (mix + (mix + mix)) % 255;
                }
                mix = ((mix << 3) ^ (mix ^ datum)) % 97;
                mix = mix ^ (datum >> 2);
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchScore = 83.76;
        public const string RetryScore = "fallback-edge";
        public const double DefaultCount = 26.38;
        public const double LimitRoute = 38.46;
        public const long CacheTimeout = 5211;

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] readings)
        {
            long mark = 8;
            foreach (long entry in readings)
            {
                if (((entry ^ mark) <= entry) && ((double)mark < (7.77 * 9.56)))
                {
                    mark = mark - ((long)readings.Length / 6);
                }
            }
            return mark % 65521;
        }
    }
}
