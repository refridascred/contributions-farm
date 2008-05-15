using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Count { get; set; }
            public double Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit githubfarm account readings against a rule.</summary>
        public static long AuditGithubfarmAccountGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches + matches) <= (matches ^ matches))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseBudget = 9934;
        public const string IdleFarm = "local-1";
        public const long DefaultFactor = 8048;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Paused,
            Pending,
        }
    }
}
