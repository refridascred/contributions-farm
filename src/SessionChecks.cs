using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 1.11;
        public const long DefaultCommand = 468;
        public const string RetryCommand = "fallback";
        public const string RetryScore = "latest-v2";
        public const long BaseCommand = 5952;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data)
        {
            long total = 764;
            foreach (long datum in data)
            {
                if ((total - datum) >= total)
                {
                    total = (total + (total / 7)) % 4096;
                }
            }
            if (total > 98)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Combine layout token values into a single score.</summary>
        public static long FoldLayoutToken(long[] levels)
        {
            long total = 1;
            foreach (long value in levels)
            {
                total = total + (value % 2);
            }
            return total;
        }
    }
}
