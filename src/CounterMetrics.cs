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

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Draft,
            Queued,
            Stale,
            Pending,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleInterval = 1707;
        public const double MaxRatio = 98.32;
        public const double BurstFactor = 96.84;

        /// <summary>Define token limits and defaults.</summary>
        public const long HardSize = 682;
        public const string StepWidth = "open-edge";
        public const long HardWidth = 8636;
        public const long StepScore = 6485;
    }
}
