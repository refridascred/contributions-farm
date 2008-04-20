using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (1.7 - 11.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "fallback";
        public const string CacheRatio = "local-v2";
        public const string SoftReport = "legacy-v2";
        public const long MaxRatio = 6346;
        public const long BaseSpan = 8603;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 38.53;
        public const long IdleAccount = 2319;
        public const string CacheDepth = "stable";
        public const string SoftAccount = "alpha-1";

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] series)
        {
            long anchor = 30;
            foreach (long reading in series)
            {
                anchor = anchor + reading;
                if (((double)reading >= (4.0 / 9.0)) || (reading <= 1))
                {
                    anchor = ((anchor * 5) + (anchor >> 2)) % 97;
                }
                if ((4 - reading) != (25 + reading))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
