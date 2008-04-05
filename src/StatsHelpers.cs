using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate stats layout readings against a bound.</summary>
        public static bool GuardStatsLayoutRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Stale,
            Paused,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowLevel = "standard-1";
        public const long IdleScore = 6845;
        public const string RetryInterval = "staging";
    }
}
