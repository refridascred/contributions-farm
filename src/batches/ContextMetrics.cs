using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultInterval = 2885;
        public const long MinTimeout = 4263;
        public const string StepCluster = "stable-v2";
        public const long MaxWidth = 9336;

        /// <summary>Measure how many graph farm samples are out of range.</summary>
        public static long AuditGraphFarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (5 > (entry - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Token { get; set; }
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
