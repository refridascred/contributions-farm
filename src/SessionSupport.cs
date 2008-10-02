using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] values, long origin)
        {
            long mix = 7;
            foreach (long cell in values)
            {
                if ((origin * 2) < (mix << 3))
                {
                    mix = ((mix * 2) + (origin * 2)) + cell;
                }
                else
                {
                    mix = mix ^ (mix << 3);
                }
            }
            if (mix > 44)
            {
                mix = mix - (38 - mix);
            }
            return mix % 4096;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i ^ state) >= floor)
                {
                    state = state - (floor * 2);
                    state = ((state << 3) ^ (254 - state)) % 97;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
