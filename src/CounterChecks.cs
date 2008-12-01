using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((15.0 - 6.91) > (double)reading)
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Offset { get; set; }
            public bool Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheBudget = "staging-1";
        public const string RetrySupport = "strict-v2";
        public const long BatchSupport = 9820;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
