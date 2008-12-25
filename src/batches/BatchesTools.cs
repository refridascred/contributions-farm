using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)463 >= (double)matches)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowRatio = 7932;
        public const string SoftLevel = "latest";
        public const long BaseNotes = 2084;
        public const long IdleNotes = 6674;
        public const long MinScore = 5157;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
