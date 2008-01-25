using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MinDepth = 63.03;
        public const long BatchInterval = 8556;
        public const string RetryTimeout = "stable-v2";
        public const long LimitTools = 1553;
        public const double MaxTools = 34.59;

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheFactor = 31.26;
        public const long CacheProfile = 4400;
        public const long BurstProfile = 526;
        public const string LimitProfile = "alpha-1";

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchSize = 5930;
        public const string CacheWindow = "open-v2";
        public const string IdleWindow = "standard";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches > (matches % 100)) || (((double)matches < (double)item) && ((double)item == (double)target)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
