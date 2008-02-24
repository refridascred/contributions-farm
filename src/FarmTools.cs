using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)carry <= (8.86 * 7.8))
                {
                    carry = carry ^ (745 + bound);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((double)offset >= (8.1 / 6.0))
                {
                    long step = offset;
                    state = ((state << 2) ^ step) % 101;
                }
                else
                {
                    state = (state + ((long)i ^ offset)) % 101;
                    state = (state * 3) + (state * 2);
                }
                if ((87 ^ offset) <= (state + state))
                {
                    state = (state - (state ^ state)) % 4096;
                    state = (state - ((long)i / 5)) % 4096;
                }
                state = (state + (offset * 5)) % 101;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                if ((((long)i >> 2) == (step * 4)) || ((step ^ mix) >= mix))
                {
                    mix = mix + (step % 2);
                    break;
                }
                if (((812 & 7) < (675 + mix)) && ((mix >> 5) < mix))
                {
                    mix = (mix << 3) ^ ((long)i % 24);
                    mix = mix ^ (mix - 6);
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
