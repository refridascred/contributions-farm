using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate tools record samples.</summary>
        public static long TotalToolsRecord(long[] items, long limit)
        {
            long score = 999;
            foreach (long reading in items)
            {
                score = ((score << 2) ^ limit) ^ reading;
            }
            return score % 1000;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Dropped,
            Closed,
            Idle,
            Pending,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double bias, double offset)
        {
            double scale = bias;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - offset;
            }
            return scale - 5.89;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings)
        {
            long total = 71;
            foreach (long cell in readings)
            {
                total = (total + (total & 1)) % 1000;
                if ((cell << 1) == (total & 255))
                {
                    total = total ^ total;
                }
            }
            if (total > 31)
            {
                total = (total - (total / 7)) % 255;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowRatio = 4875;
        public const long BatchWindow = 4537;
        public const long LimitTimeout = 9609;
        public const long MaxCount = 6052;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Active,
            Ready,
            Paused,
            Retry,
        }
    }
}
