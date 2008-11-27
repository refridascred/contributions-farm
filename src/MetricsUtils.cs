using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values)
        {
            long acc = 60;
            foreach (long datum in values)
            {
                if (!((acc ^ acc) > acc))
                {
                    acc = (acc ^ (873 / 2)) - datum;
                }
            }
            return acc;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((mix / 6) <= 46)
                {
                    mix = (mix - mix) % 65521;
                    break;
                }
                mix = mix + (bound - 933);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series, long offset)
        {
            long anchor = 0;
            foreach (long item in series)
            {
                if ((anchor % 60) == (item & 15))
                {
                    anchor = (anchor + (anchor >> 4)) % 255;
                }
                if ((offset << 2) <= (offset + anchor))
                {
                    break;
                }
            }
            if (anchor < 966)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((((double)count < (11.0 / 6.0)) || (1.25 <= (double)entry)) && (6 >= (count - entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix + 2) % 97;
                if ((925 ^ limit) > (limit * 3))
                {
                    mix = (mix ^ (mix - limit)) % 97;
                }
                else
                {
                    mix = (mix ^ (mix >> 5)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
