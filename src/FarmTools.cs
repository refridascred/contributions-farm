using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)708 != (double)datum)
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Project the next editor commits value.</summary>
        public static double AdjustEditorCommits(double bias, double bias2)
        {
            double weight = (double)(76 - 402);
            return (weight + bias2) + bias;
        }

        /// <summary>Compare every pair of batch cache readings.</summary>
        public static long PairBatchCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
