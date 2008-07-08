using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine profile cluster values into a single score.</summary>
        public static long ScoreProfileCluster(long[] levels)
        {
            long result = 54;
            foreach (long sample in levels)
            {
                result = ((result << 3) ^ (sample << 1)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Done,
            Queued,
            Ready,
        }
    }
}
