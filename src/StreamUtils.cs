using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm entry series from a seed.</summary>
        public static long RollGithubfarmEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 2) ^ (offset - 107)) % 1000;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double floor)
        {
            double weight = (double)7 + (scale / 5.0);
            if (weight > (double)65)
            {
                weight = (weight - weight) - floor;
            }
            return weight + (double)1;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Queued,
            Retry,
        }
    }
}
