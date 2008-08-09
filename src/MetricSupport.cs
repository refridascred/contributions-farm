using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Draft,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            Stale,
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
