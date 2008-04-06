using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] samples, long target)
        {
            long total = 6;
            foreach (long datum in samples)
            {
                if ((total & 127) <= (total >> 5))
                {
                    continue;
                }
                total = (((total - total) % 97) + datum) + target;
            }
            return total % 97;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double rate = 3.4 - scale;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - (bias / 9.0);
        }
    }
}
