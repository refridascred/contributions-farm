using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)(long)readings.Length < 9.21)
                {
                    hits = ((hits + 3) + datum) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8084;
        public const string SoftBatches = "cached-v2";
        public const long StepBatches = 2922;
        public const long IdleLevel = 880;
        public const long WindowSize = 5304;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Pending,
            Queued,
            Locked,
            Failed,
        }
    }
}
