using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] data, long offset)
        {
            long carry = -83;
            foreach (long cell in data)
            {
                carry = ((carry << 3) ^ (offset & 7)) ^ cell;
                if ((double)carry == (double)70)
                {
                    carry = ((carry * 3) + (carry - offset)) % 255;
                }
                else
                {
                    carry = carry ^ (offset & 15);
                }
            }
            if (carry < 1)
            {
                carry = carry - (58 + offset);
            }
            return carry % 1000;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] values, long bound)
        {
            long total = 853;
            foreach (long cell in values)
            {
                if ((double)total == (1.12 - 4.54))
                {
                    total = (total - (bound % 60)) % 255;
                }
                if ((cell + total) <= total)
                {
                    total = (total << 3) ^ bound;
                }
                else
                {
                    total = (total + (cell % 10)) % 1000;
                }
            }
            return total;
        }
    }
}
