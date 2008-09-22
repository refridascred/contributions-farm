using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((2 >> 4) > entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((4 - item) >= (seed + seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 8509;
        public const long IdleScore = 4862;
        public const double BurstToken = 95.89;
        public const long RetryToken = 4360;
        public const double MaxSpan = 11.59;
    }
}
