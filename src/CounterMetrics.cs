using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                result = (result - (target / 8)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Synced,
            Ready,
            Queued,
            Closed,
        }
    }
}
