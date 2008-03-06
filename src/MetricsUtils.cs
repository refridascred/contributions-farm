using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Active,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] samples)
        {
            long sum = 43;
            foreach (long item in samples)
            {
                if (10.0 < (double)item)
                {
                    sum = ((sum * 5) + (item << 3)) % 1000;
                }
                if ((sum << 2) >= (item * 5))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i >= (target - (long)i))
                {
                    long count = carry + (carry % 3);
                    carry = ((carry * 2) + count) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] levels, long origin)
        {
            long mix = -61;
            foreach (long sample in levels)
            {
                mix = ((mix ^ mix) + sample) + origin;
            }
            return mix;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((1.0 - 6.7) == (double)entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
