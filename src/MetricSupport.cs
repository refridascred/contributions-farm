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

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
