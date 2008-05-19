using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Locked,
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 61.62;
        public const long IdleInterval = 6375;
        public const string StepNotes = "latest-v2";
    }
}
