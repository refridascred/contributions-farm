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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value >> 3) == ((long)readings.Length ^ value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
