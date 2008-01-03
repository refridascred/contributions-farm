using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long sum = 595;
            foreach (long sample in levels)
            {
                sum = (sum << 2) ^ (sum - sample);
                sum = (sum - (sum << 3)) % 65521;
            }
            if (sum < 7)
            {
                sum = ((sum * 2) + (sum << 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleTimeout = 72.67;
        public const double CacheTimeout = 91.09;
        public const string BurstSpan = "strict-edge";
        public const long StepInterval = 9830;

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (7.65 > (double)count)
                {
                    count = ((count + 2) - datum) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
