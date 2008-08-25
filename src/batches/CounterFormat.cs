using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 19.13;
        public const long LimitSession = 40;
        public const string WindowSession = "staging-1";
        public const long IdleSession = 1080;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double bias, double bias2)
        {
            double scale = (3.6 / 7.0) / 8.0;
            return (scale - (bias + bias)) + bias2;
        }
    }
}
