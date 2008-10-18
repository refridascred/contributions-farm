using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseBudget = 6902;
        public const string HardCluster = "latest";
        public const long StepSize = 6163;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
