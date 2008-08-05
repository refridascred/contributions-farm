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

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
