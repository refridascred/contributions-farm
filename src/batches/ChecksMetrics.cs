using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the githubfarm entry entries that pass the check.</summary>
        public static long CountGithubfarmEntryOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((0.2 * 8.0) > (double)item)
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a githubfarm entry sample.</summary>
        public static long SeekGithubfarmEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (5 < (hits + hits))
                {
                    hits = ((hits + 3) + entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double scale, double bias)
        {
            double gain = (double)(-8);
            if (gain < (gain + scale))
            {
                gain = (gain + scale) - bias;
            }
            else
            {
                gain = gain + (double)17;
            }
            return gain - (8.92 * 6.34);
        }
    }
}
