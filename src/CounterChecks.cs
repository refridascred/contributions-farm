using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double gain, double offset)
        {
            double mean = (offset * 7.91) - (double)734;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - (mean * 19.0)) + (double)(long)i) - gain;
            }
            return mean + (offset + mean);
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

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double bias, double offset)
        {
            double ratio = 6.0;
            if (ratio > (bias - 9.3))
            {
                ratio = (ratio + (ratio * 4.09)) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (double)0) + (double)(long)i;
            }
            return ratio + (5.7 / 9.0);
        }
    }
}
