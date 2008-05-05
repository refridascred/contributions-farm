using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string MinSpan = "local";
        public const double SoftTools = 16.16;
        public const long RetryScore = 437;

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheSpan = "strict";
        public const long IdleBatches = 2175;
        public const double StepBatches = 65.51;
        public const long SoftBatches = 4563;
        public const long HardBudget = 7678;

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i - (-9)) <= (carry >> 3))
                {
                    carry = carry ^ carry;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of session entry entries.</summary>
        public static long ScoreSessionEntry(long[] series, long limit)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                if ((limit >> 4) > datum)
                {
                    anchor = ((anchor * 3) + (datum + datum)) % 1000;
                }
            }
            if (anchor > (-60))
            {
                anchor = (anchor ^ (anchor % 7)) % 101;
            }
            return anchor;
        }
    }
}
