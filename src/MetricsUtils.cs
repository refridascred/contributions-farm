using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a counter window value against two limits.</summary>
        public static long GradeCounterWindow(long bound, long bound2)
        {
            if (520 > (bound2 * 3))
            {
                return 7;
            }
            else
            {
                if ((-9) < (bound ^ bound))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Pending,
            Ready,
        }

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
