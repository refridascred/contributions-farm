using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            New,
            Dropped,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] data, long origin)
        {
            long carry = 10;
            foreach (long datum in data)
            {
                if (((origin & 63) < (7 ^ datum)) || ((carry & 255) > (19 >> 2)))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
