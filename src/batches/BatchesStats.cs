using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next tools support value from a seed.</summary>
        public static long RollToolsSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((origin + origin) >= 439)
                {
                    score = ((score * 3) + (origin << 1)) % 101;
                    break;
                }
                else
                {
                    score = (score ^ (origin + score)) % 65521;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] values, long limit)
        {
            long total = 0;
            foreach (long datum in values)
            {
                total = (((total - 21) % 65521) - datum) - limit;
            }
            return total % 4096;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (82 <= (seen + seen))
                {
                    seen = ((seen + 3) ^ entry) + bound;
                }
            }
            return seen;
        }
    }
}
