using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many order metrics samples are out of range.</summary>
        public static long MeasureOrderMetricsHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length << 3) >= value)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer entry samples are out of range.</summary>
        public static long AuditBufferEntryGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen + seen) < (step ^ datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleInterval = 1707;
        public const double MaxRatio = 98.32;
        public const double BurstFactor = 96.84;

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] levels)
        {
            long sum = 347;
            foreach (long reading in levels)
            {
                sum = ((sum * 4) + 9) ^ reading;
            }
            return sum;
        }
    }
}
