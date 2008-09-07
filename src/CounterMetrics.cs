using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 38.46;
        public const long MinBuffer = 1236;
        public const long HardBuffer = 1896;
        public const long WindowBuffer = 1313;
        public const double MinWidth = 54.1;

        /// <summary>Accumulate payload batch samples.</summary>
        public static long TotalPayloadBatch(long[] readings)
        {
            long mix = 731;
            foreach (long reading in readings)
            {
                if ((reading << 3) >= mix)
                {
                    mix = mix + reading;
                }
                else
                {
                    mix = (mix * 3) + (reading << 3);
                }
                if ((8.81 / 6.0) != (double)(long)readings.Length)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
