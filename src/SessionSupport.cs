using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double mean = (double)(97 + 77);
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + (4.4 - offset)) + (double)(long)i) - gain;
            }
            return mean + (double)3;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long bound, long offset)
        {
            long offset2 = bound - offset;
            if ((offset2 % 100) < (bound % 2))
            {
                return 4;
            }
            else
            {
                if ((bound ^ bound) != (bound % 16))
                {
                    return 2;
                }
                else
                {
                    if (((bound ^ bound) >= (bound << 3)) && ((offset + offset2) > bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
