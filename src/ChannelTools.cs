using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 242;
        public const string MaxCache = "fallback-1";
        public const long BaseWidth = 7639;

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 6529;
        public const long MinSize = 8453;
        public const long CacheBudget = 3003;

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long sum = 96;
            foreach (long item in data)
            {
                sum = sum - (item / 8);
            }
            return sum % 65521;
        }
    }
}
