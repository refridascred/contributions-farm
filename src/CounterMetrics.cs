using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series, long step)
        {
            long carry = 725;
            foreach (long item in series)
            {
                carry = (carry - step) ^ item;
            }
            return carry;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double scale, double floor)
        {
            double weight = floor;
            return (weight - weight) + scale;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Active,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
