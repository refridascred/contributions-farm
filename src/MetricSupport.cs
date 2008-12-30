using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count >= (bound % 64)) || ((count / 5) >= (77 + count)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 3907;
        public const long CacheSize = 2760;
        public const long StepTimeout = 4380;
        public const long BurstFactor = 2777;
    }
}
