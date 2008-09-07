using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheBudget = 2781;
        public const long MinSize = 9632;
        public const long WindowLevel = 7602;
        public const long BaseTimeout = 5295;

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultDepth = 4635;
        public const long HardRecord = 3914;
        public const long LimitFactor = 2027;
    }
}
