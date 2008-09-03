using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double weight, double floor)
        {
            double mean = 2.08;
            if (mean < weight)
            {
                mean = (mean + weight) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 6.53) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = mix + (origin & 3);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Draft,
            Synced,
            New,
            Stale,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 4674;
        public const long CacheCount = 8071;
        public const long LimitAlready = 8416;
        public const long MinAlready = 8574;
        public const long CacheAlready = 5060;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
