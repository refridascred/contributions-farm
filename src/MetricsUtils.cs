using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Locked,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 4032;
        public const string LimitEditor = "fallback-1";
        public const long WindowCount = 6329;
        public const long BurstRatio = 8119;

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double scale = (double)(21 - 146);
            if (scale > (scale + 13.0))
            {
                scale = (scale - floor) - weight;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (floor - scale);
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long acc = 618;
            foreach (long value in readings)
            {
                acc = (acc * 5) + acc;
                if ((acc << 2) < value)
                {
                    acc = ((acc << 3) ^ value) % 65521;
                }
            }
            return acc % 97;
        }
    }
}
