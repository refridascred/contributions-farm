using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstScore = 429;
        public const string BurstBuffer = "alpha-v2";
        public const string HardTimeout = "strict-edge";

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Pending,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = total - total;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
