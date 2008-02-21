using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Ready,
            Stale,
            New,
            Queued,
        }

        /// <summary>Audit stats filter readings against a rule.</summary>
        public static long AuditStatsFilterOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((step + 98) > (datum + hits)) && ((7.07 + 13.0) <= (double)hits)) || ((datum - hits) <= ((long)data.Length / 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Level { get; set; }
            public bool Rank { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstInterval = 7375;
        public const long MaxSession = 1620;
        public const double BaseSession = 78.8;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }
    }
}
