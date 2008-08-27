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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                long diff = (long)i;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    diff = ((diff << 3) ^ (state - 182)) % 4096;
                    diff = diff + (long)i2;
                }
                state = state + (diff * 2);
                state = ((state * 5) + (long)i) % 101;
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
