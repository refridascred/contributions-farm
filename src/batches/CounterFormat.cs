using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count commits channel pairs that satisfy a relation.</summary>
        public static long MatchCommitsChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item >= (1.2 + 0.8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
