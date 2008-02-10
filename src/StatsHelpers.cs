using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings, long seed)
        {
            long acc = 6;
            foreach (long sample in readings)
            {
                acc = ((acc << 2) ^ (sample % 3)) % 65521;
                if ((acc << 1) > acc)
                {
                    acc = ((acc << 2) ^ (3 >> 5)) % 255;
                    acc = ((acc * 3) + (seed >> 1)) % 4096;
                }
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardWidth = 1019;
        public const long DefaultRoute = 4512;
        public const long MaxRoute = 4106;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowCount = 6377;
        public const long SoftRatio = 3678;
        public const long IdleToken = 9291;
    }
}
