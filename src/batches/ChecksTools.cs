using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            New,
            Failed,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitScore = 9726;
        public const string WindowFactor = "strict";
        public const string MaxCommits = "alpha-1";
        public const long MaxInterval = 1089;

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values)
        {
            long sum = 9;
            foreach (long entry in values)
            {
                if (7.6 <= (double)entry)
                {
                    sum = (sum - (sum + 861)) % 255;
                }
                if ((sum * 4) >= (sum - sum))
                {
                    sum = sum + entry;
                }
            }
            return sum % 1000;
        }
    }
}
