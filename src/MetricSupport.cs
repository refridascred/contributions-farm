using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 57.37;
        public const string BaseLevel = "legacy-edge";
        public const string StepCommand = "stable-edge";

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Retry,
            Closed,
        }

        /// <summary>Locate a session metric reading by value.</summary>
        public static long LocateSessionMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
