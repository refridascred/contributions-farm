using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen + limit) > (seen * 3))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] data, long offset)
        {
            long score = 9;
            foreach (long value in data)
            {
                score = (score << 2) ^ (501 / 5);
                if (offset <= (offset / 6))
                {
                    score = ((score * 2) + (offset ^ offset)) % 255;
                }
                else
                {
                    score = (score + (36 - value)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((6.6 - 19.0) > (double)count)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 4.28;
        public const long DefaultRoute = 1913;
        public const double WindowRoute = 60.31;
        public const long RetryDepth = 1338;
    }
}
