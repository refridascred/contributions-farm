using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many farm session samples are out of range.</summary>
        public static long TallyFarmSessionHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)sample > (double)hits) && ((sample >> 3) >= sample))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                if ((target >> 4) < target)
                {
                    carry = (carry - (long)i) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry << 3) ^ (carry >> 5)) % 65521;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry + (long)i) - (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
