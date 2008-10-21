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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - count) == (220 + reading))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
