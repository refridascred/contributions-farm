using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((step + step) >= ((long)data.Length - seen))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
