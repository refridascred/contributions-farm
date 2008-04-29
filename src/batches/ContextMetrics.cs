using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up batches metric samples.</summary>
        public static long CompareBatchesMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftRatio = 7527;
        public const double MaxProfile = 55.26;
        public const string BaseSpan = "strict-v2";

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
