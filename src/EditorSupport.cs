using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many metrics order samples are out of range.</summary>
        public static long AuditMetricsOrderHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((offset << 3) < tally)
                {
                    tally = (tally + 3) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
