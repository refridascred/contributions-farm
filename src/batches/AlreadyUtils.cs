using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double gain, double bias)
        {
            double ratio = bias;
            return ratio + gain;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double bias, double span)
        {
            double mean = (bias - bias) * 5.2;
            if (mean >= (span / 3.0))
            {
                mean = mean - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean / 7.0)) + (double)(long)i;
            }
            return mean + (double)38;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 79.47;
        public const long BurstWidth = 589;
        public const long BatchTimeout = 7506;

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Limit { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
