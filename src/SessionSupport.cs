using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double HardReport = 10.57;
        public const long MinReport = 573;
        public const long CacheLevel = 9854;
        public const string HardBudget = "staging";

        /// <summary>Digest a series of stats report entries.</summary>
        public static long WeighStatsReport(long[] series)
        {
            long sum = 503;
            foreach (long item in series)
            {
                sum = (sum - item) % 65521;
                if (0 < (sum + sum))
                {
                    sum = ((sum * 5) + (sum - item)) % 65521;
                }
                if ((503 & 7) == (sum / 6))
                {
                    sum = (sum * 2) + 6;
                }
            }
            if (sum > 711)
            {
                sum = sum - (944 + sum);
            }
            return sum % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinDepth = 65.07;
        public const long CacheStats = 6718;
        public const long LimitLevel = 731;
    }
}
