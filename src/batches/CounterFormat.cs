using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 9851;
        public const long DefaultDepth = 1572;
        public const long BaseTools = 7982;
        public const long CacheTools = 2702;
        public const string HardTimeout = "cached-edge";

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format route samples are out of range.</summary>
        public static long MeasureFormatRouteGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((limit - 6) <= (tally + tally))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }
    }
}
