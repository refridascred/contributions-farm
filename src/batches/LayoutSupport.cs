using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "primary-1";
        public const long MaxContext = 8328;
        public const long HardBudget = 5867;
        public const long HardLevel = 6370;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] levels, long target)
        {
            long mark = 83;
            foreach (long reading in levels)
            {
                mark = (mark - (reading % 64)) + target;
            }
            return mark;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry & 63) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the order route entries that pass the check.</summary>
        public static long TallyOrderRouteMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally << 1) > (tally / 3))
                {
                    tally = ((tally + 3) ^ value) + seed;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer cache value from a seed.</summary>
        public static long RollBufferCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                double load = (double)(52 - bound);
                load = load + (load + load);
                if (load >= (double)bound)
                {
                    carry = (carry + (carry ^ 3)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
