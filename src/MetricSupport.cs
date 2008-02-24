using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first counter buffer entry that matches the target.</summary>
        public static long LookupCounterBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstFactor = "stable-edge";
        public const long SoftBudget = 5331;
        public const long MaxProfile = 4020;
    }
}
