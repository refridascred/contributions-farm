using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits + 26) >= 97)
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Ready,
            Synced,
            Failed,
        }
    }
}
