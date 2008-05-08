using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] values)
        {
            long carry = 5;
            foreach (long reading in values)
            {
                carry = ((carry << 3) ^ (reading & 15)) % 101;
                if ((double)reading < (8.2 / 6.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((bound + bound) <= (reading - bound))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of context stats readings.</summary>
        public static long DigestContextStats(long[] series)
        {
            long carry = -512;
            foreach (long entry in series)
            {
                if (!((double)carry >= (double)entry))
                {
                    carry = (carry - carry) % 97;
                    carry = (carry * 5) + (carry % 60);
                }
                carry = (carry + carry) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((5.0 * 13.0) == (double)hits)
                {
                    hits = ((hits + 2) ^ cell) - origin;
                }
            }
            return hits;
        }
    }
}
