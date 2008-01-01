using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double ratio, double span)
        {
            double drift = 6.0;
            if (drift < (drift - drift))
            {
                drift = (drift + (3.7 - ratio)) + span;
            }
            return drift + drift;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double mean = (double)(9 - 943);
            for (int i = 0; i < 4; i++)
            {
                mean = (((mean - (mean * 1.85)) + (double)(long)i) - ratio) - bias;
            }
            return mean + (mean - mean);
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
