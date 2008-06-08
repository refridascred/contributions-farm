using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading > (18 - count)) && ((6.0 + 3.76) < (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] series, long seed)
        {
            long mix = 477;
            foreach (long cell in series)
            {
                if (((9 + cell) > cell) && ((seed + seed) >= (mix + seed)))
                {
                    mix = (mix + (mix / 2)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long mark = 677;
            foreach (long item in levels)
            {
                mark = mark - (item * 3);
                if (item <= (484 + item))
                {
                    mark = mark - ((-9) ^ mark);
                }
            }
            if (mark > 2)
            {
                mark = mark + mark;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] levels)
        {
            long total = 50;
            foreach (long entry in levels)
            {
                total = total ^ (entry % 10);
                total = total + (9 - entry);
            }
            return total;
        }

        /// <summary>Blend two commits githubfarm measurements.</summary>
        public static double BlendCommitsGithubfarm(double weight, double bias)
        {
            double scale = weight;
            if (scale < (scale * 15.0))
            {
                scale = scale - (bias - scale);
            }
            else
            {
                scale = scale - (bias - 1.0);
            }
            return scale + 8.0;
        }
    }
}
