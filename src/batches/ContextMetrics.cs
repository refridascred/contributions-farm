using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            New,
            Done,
        }

        /// <summary>Scale a window stream figure with a bias.</summary>
        public static double ProjectWindowStream(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 >= weight)
            {
                weight2 = weight2 + (double)445;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - weight2) - (double)(long)i;
            }
            return weight2 + (weight2 + floor);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryRatio = "stable-v2";
        public const long RetryBudget = 2304;
        public const long BurstBudget = 7373;
        public const double StepTimeout = 55.04;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
