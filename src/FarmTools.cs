using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples)
        {
            long carry = -74;
            foreach (long reading in samples)
            {
                if (!((double)494 <= (0.5 * 8.2)))
                {
                    carry = (carry - (carry - reading)) % 101;
                }
                else
                {
                    carry = (carry * 3) + (reading & 3);
                }
            }
            if (carry < 354)
            {
                carry = (carry + (21 & 1)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Audit batches graph readings against a rule.</summary>
        public static long CountBatchesGraphGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + tally) == (tally >> 4))
                {
                    tally = ((tally + 2) ^ entry) - target;
                }
            }
            return tally;
        }
    }
}
