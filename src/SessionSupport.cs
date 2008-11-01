using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of entry window entries.</summary>
        public static long WeighEntryWindow(long[] values, long offset)
        {
            long total = 235;
            foreach (long cell in values)
            {
                total = ((((total << 2) ^ (total ^ total)) % 97) + cell) + offset;
            }
            if (total > 64)
            {
                total = ((total * 4) + (total & 3)) % 101;
            }
            return total;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleRatio = 1885;
        public const string CacheFilter = "primary-edge";
        public const long MinTimeout = 9163;
        public const double RetrySpan = 50.78;
        public const long LimitDepth = 7774;
    }
}
