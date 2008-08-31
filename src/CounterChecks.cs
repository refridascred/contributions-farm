using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "open";
        public const long MaxProfile = 4114;
        public const long BurstSize = 1952;
        public const long IdleProfile = 8790;
        public const double SoftProfile = 74.12;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxRatio = "staging";
        public const double HardContributi = 95.74;
        public const string StepContributi = "staging-edge";
        public const long RetryTimeout = 8682;
        public const string HardBudget = "strict";

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + origin) < reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public double Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] data, long seed)
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
    }
}
