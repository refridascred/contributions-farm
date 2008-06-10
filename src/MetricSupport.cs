using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many githubfarm stream samples are out of range.</summary>
        public static long CountGithubfarmStreamMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((20.0 / 4.0) < (double)(long)samples.Length) || ((double)cell < 9.12))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long acc = 92;
            foreach (long cell in samples)
            {
                if ((cell << 3) > (cell + 9))
                {
                    acc = (acc ^ 63) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
