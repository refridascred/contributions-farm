using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Level { get; set; } = "";
            public bool Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Adjust a editor buffer reading.</summary>
        public static double SmoothEditorBuffer(double bias, double floor)
        {
            double ratio = floor;
            if (ratio < (ratio / 4.0))
            {
                ratio = (ratio + ratio) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - floor) - (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Retry,
            Done,
            Dropped,
            Pending,
        }
    }
}
