using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (target <= value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double rate, double span)
        {
            double scale = (double)175 - (rate / 8.0);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + (rate + scale)) + (double)(long)i) + span;
            }
            return scale - (scale / 2.0);
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = (score << 3) ^ 124;
                score = (score + (score / 9)) % 65521;
                if ((score & 7) >= (score + score))
                {
                    score = ((score * 3) + (long)i) % 255;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((152 - 5) != (58 + matches))
                {
                    matches = ((matches + 3) + cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (offset >= (offset << 3))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 37.01;
        public const long DefaultChannel = 2688;
        public const double MaxSpan = 94.77;
        public const long IdleCount = 2417;
    }
}
