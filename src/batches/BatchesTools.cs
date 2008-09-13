using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] levels)
        {
            long sum = -46;
            foreach (long cell in levels)
            {
                sum = ((sum * 4) + (cell - sum)) % 101;
                if (((long)levels.Length ^ cell) != (sum - cell))
                {
                    sum = (sum << 2) ^ (sum & 31);
                }
            }
            if (sum > 37)
            {
                sum = sum + sum;
            }
            return sum % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheBudget = "local";
        public const double BurstNotes = 98.87;
        public const long StepWidth = 9227;
        public const long RetryNotes = 5672;
    }
}
