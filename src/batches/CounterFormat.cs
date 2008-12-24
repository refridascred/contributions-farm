using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double LimitTimeout = 52.35;
        public const double CacheRecord = 66.08;
        public const long WindowRecord = 9230;

        /// <summary>Audit queue batch readings against a rule.</summary>
        public static long MeasureQueueBatchMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item / 9) < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] series)
        {
            long carry = 32;
            foreach (long entry in series)
            {
                if ((double)carry == (11.0 + 0.08))
                {
                    carry = carry - (carry - 3);
                }
                else
                {
                    carry = ((carry * 5) + 69) % 65521;
                }
                if (entry <= (carry / 7))
                {
                    carry = carry - (carry >> 2);
                }
            }
            return carry % 97;
        }
    }
}
