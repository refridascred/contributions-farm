using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long offset, long seed)
        {
            long edge = offset ^ seed;
            if (((offset + offset) >= seed) || ((edge * 3) < (offset + 15)))
            {
                return 0;
            }
            else
            {
                if (14.0 >= (double)seed)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double drift = (bias - bias) - (5.3 + bias);
            if (drift > (bias + bias))
            {
                drift = (drift - (drift / 4.0)) - scale;
            }
            return drift - bias;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleBudget = 6852;
        public const string DefaultEditor = "primary-edge";
        public const long IdleRatio = 1341;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (74 > (count / 4))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
