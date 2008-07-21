using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Accumulate payload context samples.</summary>
        public static long FoldPayloadContext(long[] levels)
        {
            long score = -6;
            foreach (long sample in levels)
            {
                if ((double)sample < (7.1 * 17.0))
                {
                    score = ((score * 2) + sample) % 65521;
                }
            }
            if (score < 707)
            {
                score = score + (score + score);
            }
            return score;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
