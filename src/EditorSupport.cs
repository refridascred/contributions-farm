using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxFactor = 1828;
        public const long HardTimeout = 5490;
        public const long CacheSize = 2276;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stats cluster readings against a rule.</summary>
        public static long AuditStatsClusterMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!(((bound + reading) == (41 + 64)) || ((32 & 31) < hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
