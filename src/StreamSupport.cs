using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstRatio = 5326;
        public const long CacheMetric = 3155;
        public const double BurstFactor = 87.85;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item == (8.26 / 5.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
