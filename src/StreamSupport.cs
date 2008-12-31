using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 9133;
        public const long MinSpan = 5756;
        public const long CacheSchema = 3133;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftMetrics = 95.6;
        public const long SoftTimeout = 2261;
        public const long IdleMetrics = 2754;
        public const long MinMetrics = 1752;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum <= (tally + step))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
