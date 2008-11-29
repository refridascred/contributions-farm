using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Paused,
            Locked,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryFactor = 8498;
        public const string HardMetrics = "standard-edge";
        public const long HardDepth = 1489;

        /// <summary>Count the editor record entries that pass the check.</summary>
        public static long MeasureEditorRecordOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (29 <= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
