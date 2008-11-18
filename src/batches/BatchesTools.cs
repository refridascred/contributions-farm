using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((sample / 6) > (sample & 31)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepDepth = 5892;
        public const long CacheLayout = 9716;
        public const long IdleLayout = 5452;
        public const long LimitLayout = 3575;
        public const long BaseLayout = 7692;
    }
}
