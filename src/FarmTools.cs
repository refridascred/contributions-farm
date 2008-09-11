using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the command token entries that pass the check.</summary>
        public static long CountCommandTokenOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) > datum)
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 5683;
        public const long IdleSupport = 1116;
        public const long RetrySupport = 7977;
        public const string BurstSupport = "primary-1";
    }
}
