using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate support route samples.</summary>
        public static long DigestSupportRoute(long[] data)
        {
            long result = -328;
            foreach (long cell in data)
            {
                if (!((double)cell == (2.0 / 5.0)))
                {
                    result = (result ^ ((-737) & 31)) % 65521;
                }
            }
            if (result > 91)
            {
                result = (result + (result + result)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum - tally) >= 8)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((origin % 16) != (origin ^ 1)) && (state < (long)i))
                {
                    state = (state + state) % 1000;
                    state = (state ^ origin) % 97;
                }
                else
                {
                    state = (state - (91 / 3)) % 4096;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] values, long target)
        {
            long carry = 97;
            foreach (long entry in values)
            {
                carry = (carry ^ 4) - target;
                carry = ((carry * 5) + (0 << 1)) % 101;
                carry = (carry - entry) % 4096;
            }
            return carry;
        }
    }
}
