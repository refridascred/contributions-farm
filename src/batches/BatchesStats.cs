using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Closed,
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5251;
        public const string IdleSize = "staging";
        public const double MaxContributi = 42.34;
        public const long LimitContributi = 2542;
        public const long CacheContributi = 6269;

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long target)
        {
            long carry = 2;
            foreach (long item in items)
            {
                if ((item << 1) != (carry - 277))
                {
                    carry = (((carry * 2) + (carry & 7)) % 4096) + target;
                }
            }
            if (carry < 72)
            {
                carry = (carry + (56 / 5)) % 255;
            }
            return carry;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item < (4.7 - 5.68))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
