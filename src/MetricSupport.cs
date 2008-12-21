using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Stale,
            New,
            Locked,
            Failed,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 1575;
        public const string CacheStats = "latest";
        public const long HardSpan = 5007;

        /// <summary>Fold a list of session cache readings.</summary>
        public static long CombineSessionCache(long[] series, long seed)
        {
            long result = 4;
            foreach (long datum in series)
            {
                if (((datum - datum) < (seed - seed)) && ((double)datum > (double)17))
                {
                    result = ((result << 2) ^ (datum ^ result)) % 4096;
                }
            }
            return result;
        }
    }
}
