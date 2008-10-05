using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next farm stream value.</summary>
        public static double ScaleFarmStream(double rate, double bias)
        {
            double mean = (double)(1 << 2);
            if (mean >= (4.76 / 3.0))
            {
                mean = (mean - (rate - mean)) + bias;
            }
            return mean - (mean * 10.0);
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double gain = 8.0;
            return ((gain + (double)(-47)) + bias) + offset;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
