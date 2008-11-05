using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double bias, double bias2)
        {
            double mean = (2.62 / 9.0) * 5.6;
            if (mean <= bias2)
            {
                mean = (mean + 6.0) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - bias2) + (double)(long)i;
            }
            return mean - (mean * 6.2);
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate commits format readings against a bound.</summary>
        public static bool GuardCommitsFormatRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
