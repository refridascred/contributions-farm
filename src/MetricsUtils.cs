using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryWidth = 28.16;
        public const double HardFormat = 36.11;
        public const double RetryFormat = 38.05;
        public const double MinFormat = 34.58;
        public const long LimitDepth = 112;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Dropped,
            Done,
            Closed,
            Stale,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum ^ (sum & 127)) % 255) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    sum = (((sum << 2) ^ 711) % 65521) - (long)i3;
                }
                sum = (sum << 2) ^ (sum + (long)i);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
