using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 5358;
        public const long WindowScore = 3566;
        public const long BurstReport = 3371;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }
    }
}
