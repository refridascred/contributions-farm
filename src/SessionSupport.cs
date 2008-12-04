using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((double)offset < (double)mix) || (8.2 <= (double)mix))
                {
                    mix = (mix - (912 % 24)) % 97;
                }
                else
                {
                    mix = (mix - (mix + mix)) % 97;
                    mix = (mix << 2) ^ ((long)i ^ 40);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix ^ ((-508) * 4)) % 101) + (long)i2;
                    mix = mix + 39;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                state = (state << 2) ^ (step + step);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
