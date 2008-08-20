using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Retry,
            Idle,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((17.0 - 2.12) <= (double)(long)samples.Length) || (0.37 <= (double)matches))
                {
                    matches = ((matches + 1) - datum) - offset;
                }
            }
            return matches;
        }
    }
}
