using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] items)
        {
            long mix = 6;
            foreach (long sample in items)
            {
                if (sample <= (mix + mix))
                {
                    mix = ((mix << 2) ^ sample) % 101;
                }
            }
            return mix;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((5.0 > (double)floor) && ((cell >= (907 ^ floor)) && ((seen << 3) < cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values)
        {
            long carry = 7;
            foreach (long datum in values)
            {
                carry = ((carry * 5) + (carry / 4)) - datum;
                carry = carry + (carry + carry);
            }
            return carry;
        }
    }
}
