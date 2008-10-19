using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Locked,
            New,
            Retry,
        }

        /// <summary>Audit metric batches readings against a rule.</summary>
        public static long MeasureMetricBatchesGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)tally == (5.17 + 2.63)) || !((9.1 * 14.0) <= (double)entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long floor)
        {
            long carry = -432;
            foreach (long entry in levels)
            {
                if (!(0.5 <= (double)floor))
                {
                    carry = (((carry << 2) ^ (floor << 1)) % 101) - entry;
                }
                carry = (carry + carry) % 1000;
            }
            return carry;
        }
    }
}
