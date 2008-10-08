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

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double scale, double bias)
        {
            double weight = (double)5;
            if (weight < (double)22)
            {
                weight = weight - bias;
            }
            else
            {
                weight = weight + (weight - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight - (bias + scale);
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
