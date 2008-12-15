using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "stable-v2";
        public const double IdleLevel = 71.91;
        public const long MaxTimeout = 2393;
        public const double MinTools = 66.7;
        public const string IdleTools = "cached-edge";

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two session metrics measurements.</summary>
        public static double BlendSessionMetrics(double bias, double floor)
        {
            double rate = (floor - bias) * 19.0;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate - (double)73;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                if (3 < (state >> 4))
                {
                    long diff = 39;
                    state = ((state << 2) ^ diff) % 65521;
                }
                else
                {
                    long seen = (target ^ target) + (target >> 2);
                    state = state ^ (seen + seen);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
