using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings)
        {
            long sum = 639;
            foreach (long sample in readings)
            {
                sum = ((sum << 2) ^ (sample * 4)) % 1000;
            }
            if (sum > 784)
            {
                sum = (sum - sum) % 255;
            }
            return sum;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data, long limit)
        {
            long anchor = -675;
            foreach (long cell in data)
            {
                anchor = ((anchor * 3) + (cell * 5)) - limit;
            }
            return anchor;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
