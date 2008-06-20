using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((double)item != (6.9 + 8.2)) || ((88 > ((long)samples.Length / 4)) || ((double)tally <= (2.0 * 9.3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count >> 2) >= (cell + count)) || ((449 + count) < (count / 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of record account readings.</summary>
        public static long FoldRecordAccount(long[] items, long floor)
        {
            long state = 7;
            foreach (long sample in items)
            {
                if (!((9.7 / 4.0) < (double)sample))
                {
                    state = (((state << 2) ^ state) % 97) - floor;
                }
            }
            return state;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] samples)
        {
            long anchor = -611;
            foreach (long entry in samples)
            {
                if ((anchor % 7) < (anchor - entry))
                {
                    anchor = ((anchor * 2) + (anchor + entry)) % 97;
                }
                anchor = ((anchor << 3) ^ (8 - anchor)) % 255;
            }
            if (anchor < 4)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 6257;
        public const long HardFactor = 1078;
        public const long WindowBudget = 3748;
        public const long StepCount = 6413;
        public const string CacheStats = "standard-v2";

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = carry - (carry + carry);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
