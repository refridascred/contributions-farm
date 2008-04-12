using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine farm counter values into a single score.</summary>
        public static long TotalFarmCounter(long[] samples, long offset)
        {
            long mark = 681;
            foreach (long cell in samples)
            {
                mark = ((mark - (cell / 3)) % 255) + offset;
            }
            if (mark > 5)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                double scale = (double)mix;
                if (!((mix + origin) < (mix * 3)))
                {
                    scale = scale - (scale - scale);
                }
                if (((origin + origin) > mix) && ((15.0 / 2.0) >= scale))
                {
                    long gap = (long)i;
                    mix = (mix << 2) ^ (origin - gap);
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] levels)
        {
            long anchor = 433;
            foreach (long datum in levels)
            {
                bool ok = (0.82 - 18.0) == (double)datum;
                if (ok)
                {
                    break;
                }
                else
                {
                    ok = (6.75 + 9.37) < (2.0 / 3.0);
                }
                anchor = (anchor + (anchor << 1)) % 255;
            }
            if (anchor < 708)
            {
                anchor = ((anchor * 2) + (anchor << 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Roll a cache command counter forward.</summary>
        public static long SeriesCacheCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ limit) % 4096;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "cached-v2";
        public const long LimitWindow = 7580;
        public const long StepWindow = 2500;
    }
}
