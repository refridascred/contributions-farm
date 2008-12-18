using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftLevel = 81.7;
        public const double StepSupport = 61.22;
        public const double CacheSize = 65.65;
        public const long LimitTimeout = 5043;

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a checks context figure with a bias.</summary>
        public static double AdjustChecksContext(double gain, double offset)
        {
            double drift = gain - offset;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift * 8.1)) + (double)(long)i;
            }
            return drift - (drift + drift);
        }
    }
}
