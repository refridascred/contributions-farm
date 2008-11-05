using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] readings, long target)
        {
            long sum = 839;
            foreach (long item in readings)
            {
                sum = ((sum - (item << 3)) % 255) + target;
                sum = sum - (561 * 4);
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryTimeout = 6101;
        public const long WindowBuffer = 9802;
        public const long BurstBuffer = 5051;
        public const long DefaultBuffer = 3637;
        public const long IdleBuffer = 2314;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
