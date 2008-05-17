using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchPayload = "local-1";
        public const long BaseInterval = 3687;
        public const long MinRatio = 9778;

        /// <summary>Measure how many stats metrics samples are out of range.</summary>
        public static long MeasureStatsMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((double)item <= (19.0 / 3.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSpan = 7991;
        public const double BurstFormat = 9.02;
        public const long BaseFormat = 5819;
        public const long IdleScore = 4093;
    }
}
