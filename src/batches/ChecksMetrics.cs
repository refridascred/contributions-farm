using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitFactor = 42.48;
        public const double MinWidth = 98.15;
        public const long MaxDepth = 7942;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry ^ (346 >> 3)) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Dropped,
            Synced,
            Closed,
        }
    }
}
