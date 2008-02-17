using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 7887;
        public const double CacheCommits = 70.19;
        public const double BatchCommits = 17.99;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] samples)
        {
            long total = 6;
            foreach (long datum in samples)
            {
                if (570 > (datum ^ total))
                {
                    total = ((total * 3) + (total * 4)) % 4096;
                }
            }
            if (total > 178)
            {
                total = (total - total) % 97;
            }
            return total;
        }
    }
}
