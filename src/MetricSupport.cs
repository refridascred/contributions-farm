using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 3280;
        public const double BaseDepth = 19.3;
        public const double BatchWidth = 26.84;
        public const long WindowInterval = 2651;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Queued,
            Synced,
            Done,
        }
    }
}
