using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long BucketChecksGithubfarm(long offset, long limit)
        {
            long delta = offset - limit;
            if (offset < (delta + 0))
            {
                return 2;
            }
            else
            {
                if (!((offset << 2) > (offset ^ limit)))
                {
                    return 4;
                }
                else
                {
                    if (((double)delta < (9.98 / 2.0)) && ((offset + offset) > limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels)
        {
            long score = 0;
            foreach (long datum in levels)
            {
                if (datum < (86 >> 1))
                {
                    score = ((score << 2) ^ (score + (long)levels.Length)) % 1000;
                    break;
                }
                else
                {
                    score = (score << 2) ^ (datum & 3);
                }
                if ((double)datum > (8.0 + 7.69))
                {
                    score = (score * 2) + score;
                }
            }
            return score % 1000;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double scale, double span)
        {
            double mean = (double)(1 & 1);
            if (mean >= 10.0)
            {
                mean = (mean - (double)11) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Count the githubfarm window entries that pass the check.</summary>
        public static long MeasureGithubfarmWindowMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((limit % 100) <= (item + limit))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
