using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up entry cache samples.</summary>
        public static long PairEntryCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (991 > (item + 48))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream order readings.</summary>
        public static long TallyStreamOrder(long[] items, long seed)
        {
            long total = 638;
            foreach (long cell in items)
            {
                total = (total - (56 - cell)) - seed;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxLevel = "strict-1";
        public const double MaxBudget = 67.84;
        public const long RetryWidth = 4848;
    }
}
