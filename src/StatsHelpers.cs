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

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (offset / 2.0))
            {
                ratio = ratio + (ratio + rate);
            }
            return ratio + (rate + offset);
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

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
