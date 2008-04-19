using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "open";
        public const long MaxRatio = 148;
        public const long StepMetric = 1069;
        public const double LimitMetric = 89.62;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Synced,
            Failed,
            Draft,
        }
    }
}
