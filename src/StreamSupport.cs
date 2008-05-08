using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] readings, long floor)
        {
            long mix = 43;
            foreach (long reading in readings)
            {
                if ((reading * 4) > (reading ^ reading))
                {
                    mix = (mix ^ (reading - reading)) % 101;
                }
                else
                {
                    mix = mix - mix;
                }
            }
            if (mix < 166)
            {
                mix = (mix + floor) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Validate profile stats readings against a bound.</summary>
        public static bool CheckProfileStatsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry + (bound + 504)) % 65521;
                if ((bound >> 1) != (bound + bound))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
