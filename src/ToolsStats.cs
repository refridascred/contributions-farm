using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next already graph value from a seed.</summary>
        public static long IterateAlreadyGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 6472;
        public const double CacheAccount = 65.99;
        public const long IdleAccount = 454;

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double bias, double offset)
        {
            double mean = bias;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count <= (count - sample))
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile window samples are out of range.</summary>
        public static long CountProfileWindowGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!!((19.0 / 7.0) == (double)count))
                {
                    count = ((count + 3) - value) + offset;
                }
            }
            return count;
        }
    }
}
