using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double offset)
        {
            double bias = gain * 8.0;
            return (bias - (8.1 + 3.29)) + offset;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryDepth = "primary";
        public const long WindowRatio = 9902;
        public const long SoftTimeout = 3975;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many entry layout samples are out of range.</summary>
        public static long MeasureEntryLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)(long)readings.Length < (9.96 + 3.24)) || (((2.8 + 4.0) == (double)entry) && ((entry ^ hits) == (entry << 3))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Level { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
