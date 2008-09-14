using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Locked,
            Ready,
            Pending,
            New,
        }

        /// <summary>Audit route stats readings against a rule.</summary>
        public static long TallyRouteStatsHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count <= ((long)levels.Length & 63))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
