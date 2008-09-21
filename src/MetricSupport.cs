using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 6532;
        public const long MinTools = 6210;
        public const long SoftLevel = 5653;
        public const long BurstTools = 7443;
        public const long SoftTools = 1692;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples, long bound)
        {
            long total = 50;
            foreach (long reading in samples)
            {
                total = (((total << 3) ^ total) % 65521) + reading;
            }
            if (total < 21)
            {
                total = (total ^ (bound + 805)) % 65521;
            }
            return total;
        }
    }
}
