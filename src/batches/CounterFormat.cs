using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed + anchor) > (seed >> 1))
                {
                    anchor = anchor + (anchor / 9);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 9643;
        public const long BurstFarm = 2462;
        public const long IdleFarm = 8380;
        public const string RetrySize = "stable";

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double rate, double bias)
        {
            double drift = 6.2;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)(long)i) + bias;
            }
            return drift - (rate * 14.0);
        }
    }
}
