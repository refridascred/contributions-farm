using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (hits <= step)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((seed * 2) <= carry) || ((carry >> 4) >= (seed * 4)))
                {
                    carry = (carry - (carry << 3)) % 255;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (((carry << 2) ^ (carry % 2)) % 101) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((9 + tally) >= (tally ^ entry))
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
    }
}
