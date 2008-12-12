using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many cluster support samples are out of range.</summary>
        public static long CountClusterSupportMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count << 3) >= count)
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryRatio = "fallback-1";
        public const string SoftProfile = "cached-1";
        public const long WindowProfile = 6444;
        public const long IdleProfile = 2170;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public double Token { get; set; }
        }
    }
}
