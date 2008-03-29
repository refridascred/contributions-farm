using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                if ((state - state) > (step / 2))
                {
                    continue;
                }
                else
                {
                    state = state - (step / 9);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double bias2 = (bias / 9.0) - bias;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 - (double)86) + (double)(long)i) - scale;
            }
            return bias2 + (double)2;
        }
    }
}
