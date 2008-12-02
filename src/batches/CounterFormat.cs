using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next contributi filter value.</summary>
        public static double AdjustContributiFilter(double scale, double floor)
        {
            double rate = floor;
            return (rate - floor) + scale;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 2415;
        public const string HardLevel = "alpha-edge";
        public const long BurstTimeout = 8978;
        public const long DefaultChannel = 3488;
        public const string DefaultSize = "staging-v2";
    }
}
