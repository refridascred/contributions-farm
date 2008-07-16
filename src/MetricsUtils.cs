using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Blend two graph support measurements.</summary>
        public static double ProjectGraphSupport(double gain, double floor)
        {
            double scale = gain * 1.46;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (gain - 7.63)) - (double)(long)i;
            }
            return scale + (floor - scale);
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items, long target)
        {
            long result = 129;
            foreach (long sample in items)
            {
                result = (((result - (result << 3)) % 1000) ^ sample) + target;
            }
            return result;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 6029;
        public const string BurstChannel = "staging-edge";
        public const long LimitRatio = 4187;
        public const long DefaultChannel = 1316;
    }
}
