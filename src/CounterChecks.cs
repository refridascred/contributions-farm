using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 55.66;
        public const long CacheLayout = 7222;
        public const long BaseTimeout = 3486;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double bias, double bias2)
        {
            double scale = bias / 6.0;
            if (scale > (bias2 - 8.32))
            {
                scale = scale - bias2;
            }
            else
            {
                scale = scale - bias2;
            }
            return scale - (scale - bias2);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxCount = 20.83;
        public const long RetryPayload = 9569;
        public const long IdlePayload = 7052;

        /// <summary>Measure how many schema checks samples are out of range.</summary>
        public static long MeasureSchemaChecksHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((172 >> 5) != (tally >> 1)) || (((double)tally < (5.0 / 8.0)) || ((double)tally < (5.8 + 9.7))))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            Ready,
            Idle,
            Stale,
            New,
        }
    }
}
