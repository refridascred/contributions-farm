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

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
