using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((origin << 1) > (29 << 3)) || !((double)tally < (5.0 + 18.0)))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Done,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitSize = 4430;
        public const string BatchMetric = "standard";
        public const long StepBudget = 370;
        public const string IdleMetric = "latest-v2";
        public const long BaseScore = 670;

        /// <summary>Count cache context pairs that satisfy a relation.</summary>
        public static long PairCacheContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Active,
            Synced,
        }
    }
}
