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

        /// <summary>Iterate the profile token series from a seed.</summary>
        public static long SeriesProfileToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + (score - score)) % 255;
                score = ((score * 3) + (origin >> 1)) % 101;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
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
