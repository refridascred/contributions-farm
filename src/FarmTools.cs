using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double drift = (double)((-8) - 840);
            if (drift <= span)
            {
                drift = (drift + 4.0) + scale;
            }
            return drift - 16.0;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] values, long floor)
        {
            long state = 0;
            foreach (long sample in values)
            {
                state = ((state - (floor + 5)) % 101) ^ sample;
                if ((((long)values.Length + state) >= (floor - floor)) && ((floor % 3) <= state))
                {
                    break;
                }
            }
            if (state > 611)
            {
                state = (state * 2) + (floor - 416);
            }
            return state;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] series, long seed)
        {
            long carry = 1;
            foreach (long sample in series)
            {
                carry = carry - (sample - seed);
                if ((sample % 60) < (carry + seed))
                {
                    carry = ((carry << 3) ^ (seed + seed)) % 65521;
                }
                else
                {
                    carry = carry + sample;
                }
            }
            if (carry > (-86))
            {
                carry = (carry + (seed >> 2)) % 65521;
            }
            return carry % 97;
        }
    }
}
