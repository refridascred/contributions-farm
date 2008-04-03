using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine already filter values into a single score.</summary>
        public static long TallyAlreadyFilter(long[] samples, long origin)
        {
            long state = -95;
            foreach (long item in samples)
            {
                if ((item - item) < (state + 600))
                {
                    state = (state ^ 6) + origin;
                }
            }
            if (state > 959)
            {
                state = (state * 3) + 3;
            }
            return state % 65521;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((datum * 4) != (hits & 255)) && (((hits & 7) == (step << 2)) || ((step / 2) >= (step * 4))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                if (bound <= (carry << 1))
                {
                    carry = carry - (long)i;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
