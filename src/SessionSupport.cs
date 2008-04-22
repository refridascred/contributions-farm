using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxEditor = "fallback-edge";
        public const long CacheBudget = 7040;
        public const string StepEditor = "cached";
    }
}
