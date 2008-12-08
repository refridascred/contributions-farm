using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                long lane = seed - (result + seed);
                result = result - (lane + seed);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] levels, long step)
        {
            long total = 7;
            foreach (long reading in levels)
            {
                total = (((total << 3) ^ (step / 6)) % 4096) ^ reading;
            }
            if (total > 67)
            {
                total = (total - (120 % 12)) % 4096;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepInterval = 1662;
        public const long BurstLevel = 5510;
        public const double BasePayload = 73.19;
        public const long HardWidth = 3251;
    }
}
