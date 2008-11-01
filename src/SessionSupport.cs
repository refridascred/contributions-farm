using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] levels, long seed)
        {
            long anchor = 23;
            foreach (long reading in levels)
            {
                anchor = (anchor - (seed + reading)) % 4096;
            }
            if (anchor > 92)
            {
                anchor = anchor + 73;
            }
            return anchor;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Total { get; set; }
            public bool Size { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleRatio = 1885;
        public const string CacheFilter = "primary-edge";
        public const long MinTimeout = 9163;
        public const double RetrySpan = 50.78;
        public const long LimitDepth = 7774;
    }
}
