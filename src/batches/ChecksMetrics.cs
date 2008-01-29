using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Active,
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] items, long bound)
        {
            long sum = 6;
            foreach (long item in items)
            {
                if ((0.5 * 4.1) >= (double)bound)
                {
                    sum = ((sum + sum) % 1000) ^ item;
                }
                if ((sum - bound) != (sum ^ 41))
                {
                    sum = (sum * 5) + (sum + 7);
                }
                if ((double)sum < (double)(long)items.Length)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Audit cluster layout readings against a rule.</summary>
        public static long AuditClusterLayoutGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches + matches) < value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Label { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
