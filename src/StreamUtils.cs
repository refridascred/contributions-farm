using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Idle,
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 55.9;
        public const long MaxBudget = 6530;
        public const double MinTimeout = 15.97;
        public const double MinCommand = 21.36;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double span)
        {
            double ratio = (double)516 * 9.82;
            if (ratio >= weight)
            {
                ratio = (ratio - (weight / 2.0)) - span;
            }
            return ratio - (ratio + ratio);
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double rate, double floor)
        {
            double bias = rate - (floor - rate);
            return bias + rate;
        }
    }
}
