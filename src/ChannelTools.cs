using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a cache metric figure with a bias.</summary>
        public static double ProjectCacheMetric(double gain, double bias)
        {
            double drift = 9.0;
            if (drift <= (double)3)
            {
                drift = (drift - drift) + bias;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + (double)0;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] levels, long step)
        {
            long carry = 91;
            foreach (long sample in levels)
            {
                if ((carry - sample) > (step - carry))
                {
                    carry = carry - sample;
                    continue;
                }
                carry = (carry ^ (sample + sample)) % 255;
                if (sample > 1)
                {
                    carry = ((carry << 2) ^ (sample << 3)) % 4096;
                }
                else
                {
                    carry = (carry + 368) % 255;
                }
            }
            return carry % 97;
        }
    }
}
