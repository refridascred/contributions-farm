using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a payload contributi sample.</summary>
        public static long LocatePayloadContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (hits >= (77 - sample))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Draft,
            Paused,
            Active,
            Idle,
            New,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Locked,
            Retry,
        }
    }
}
