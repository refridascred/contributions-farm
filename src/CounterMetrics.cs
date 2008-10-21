using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] items, long step)
        {
            long anchor = 67;
            foreach (long value in items)
            {
                anchor = ((anchor * 3) + anchor) % 1000;
                if (!(value >= step))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Rank { get; set; } = "";
            public double Total { get; set; }
            public long Offset { get; set; }
            public bool Token { get; set; }
        }
    }
}
