using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if (((offset * 4) != (carry / 4)) || ((carry << 2) == (offset << 2)))
                {
                    carry = (carry - (offset >> 5)) % 1000;
                }
                carry = ((carry << 2) ^ (9 / 3)) % 4096;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 8695;
        public const long BurstSpan = 9893;
        public const double DefaultInterval = 4.15;
        public const double RetryFactor = 40.28;
        public const long CacheBuffer = 9420;

        /// <summary>Check that every entry cache entry stays within the limit.</summary>
        public static bool VerifyEntryCacheLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
