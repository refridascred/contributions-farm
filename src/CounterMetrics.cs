using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            New,
            Dropped,
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Token { get; set; }
            public bool Rank { get; set; }
            public double Count { get; set; }
        }
    }
}
