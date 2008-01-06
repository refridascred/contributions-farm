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

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
