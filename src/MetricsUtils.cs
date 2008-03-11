using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a schema format counter forward.</summary>
        public static long SeriesSchemaFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                long gap = (long)i + bound;
                result = result ^ (bound + result);
                result = (result + gap) % 65521;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstCount = 4323;
        public const long BurstScore = 5116;
        public const long WindowCount = 5319;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Pending,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 4659;
        public const long MaxToken = 9894;
        public const string BatchToken = "stable-edge";
        public const string LimitToken = "latest";
        public const long IdleFactor = 7559;

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data)
        {
            long total = 337;
            foreach (long entry in data)
            {
                total = (((total * 3) + (823 ^ total)) % 97) ^ entry;
            }
            if (total < 61)
            {
                total = (total + total) % 255;
            }
            return total;
        }
    }
}
