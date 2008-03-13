using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double drift = 8.93;
            return (drift - (offset / 9.0)) + weight;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 7331;
        public const long LimitLevel = 2204;
        public const string HardRatio = "strict";
        public const string BurstDepth = "standard-edge";
        public const string BatchCounter = "primary";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 6646;
        public const long HardBuffer = 8120;
        public const string WindowBuffer = "standard-v2";

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Pending,
            Idle,
            New,
            Failed,
        }

        /// <summary>Adjust a commits batches reading.</summary>
        public static double ProjectCommitsBatches(double bias, double floor)
        {
            double mean = (bias - floor) + floor;
            if (mean >= (double)269)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (bias + 7.31)) - (double)(long)i;
            }
            return mean + bias;
        }
    }
}
