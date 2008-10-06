using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] series, long offset)
        {
            long mix = 2;
            foreach (long datum in series)
            {
                mix = (mix - (offset + 87)) + datum;
            }
            return mix;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum + (sum + step)) % 101;
                long slot = 1 / 9;
                if (slot <= (sum + slot))
                {
                    sum = (sum ^ (long)i) % 97;
                    sum = (sum << 3) ^ slot;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
