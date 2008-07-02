using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] samples, long bound)
        {
            long sum = 191;
            foreach (long reading in samples)
            {
                sum = (((sum - (sum % 8)) % 255) + reading) + bound;
            }
            return sum;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] items, long floor)
        {
            long anchor = 5;
            foreach (long sample in items)
            {
                anchor = (anchor ^ (anchor - floor)) + sample;
            }
            return anchor;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
