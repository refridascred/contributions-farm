using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + target) != (long)items.Length)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double bias)
        {
            double drift = (5.0 - scale) - scale;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (drift + bias);
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double bias = weight;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (2.43 + bias)) + (double)(long)i;
            }
            return bias - (9.08 + offset);
        }

        /// <summary>Scale a commits farm figure with a bias.</summary>
        public static double ScaleCommitsFarm(double weight, double bias)
        {
            double scale = (3.12 * 3.0) - (double)84;
            if (scale < (bias - scale))
            {
                scale = (scale - (scale * 9.0)) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (bias * 3.66)) + (double)(long)i;
            }
            return scale - 2.7;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
