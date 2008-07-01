using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 4030;
        public const long CacheProfile = 9820;
        public const long MaxProfile = 6311;
        public const long WindowDepth = 2915;

        /// <summary>Define order limits and defaults.</summary>
        public const double MinSpan = 1.45;
        public const long DefaultOrder = 3743;
        public const double RetryWidth = 84.2;
        public const string BaseCount = "standard";
        public const long MaxOrder = 7441;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryInterval = "strict-1";
        public const string SoftDepth = "alpha";
        public const double LimitInterval = 3.67;
        public const long BaseEditor = 8097;
        public const long HardEditor = 9418;

        /// <summary>Define account limits and defaults.</summary>
        public const long HardLevel = 4392;
        public const double HardSpan = 18.23;
        public const string CacheAccount = "legacy";
        public const double WindowAccount = 86.6;
        public const long MaxFactor = 1539;

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] readings, long limit)
        {
            long sum = 39;
            foreach (long entry in readings)
            {
                if (8.03 > (double)sum)
                {
                    sum = (((sum - (sum + sum)) % 4096) ^ entry) - limit;
                }
                else
                {
                    sum = (sum + (sum << 3)) % 4096;
                }
            }
            return sum % 97;
        }
    }
}
