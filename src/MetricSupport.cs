using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardCount = "staging-v2";
        public const long BatchLevel = 1892;
        public const long SoftSession = 3796;
        public const double HardRatio = 26.68;
        public const long IdleWidth = 5727;

        /// <summary>Compare every pair of notes support readings.</summary>
        public static long CompareNotesSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
