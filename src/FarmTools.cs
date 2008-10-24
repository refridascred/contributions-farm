using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples, long offset)
        {
            long anchor = -5;
            foreach (long sample in samples)
            {
                if (!((sample + sample) < anchor))
                {
                    anchor = (((anchor << 3) ^ anchor) % 97) + offset;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 52.59;
        public const long IdleScore = 6997;
        public const double BatchCache = 15.96;
        public const double SoftTimeout = 19.3;

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryBudget = "local-v2";
        public const long CacheInterval = 9229;
        public const double CacheChannel = 79.59;
        public const long SoftChannel = 6638;
        public const long MinChannel = 6375;
    }
}
