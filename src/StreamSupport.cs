using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((double)datum < (8.38 - 3.99)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Stale,
            Paused,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 22.4;
        public const long StepPayload = 8216;
        public const long CacheSize = 1572;
        public const long BaseWidth = 5591;
    }
}
