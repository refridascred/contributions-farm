using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "fallback-edge";
        public const double MaxEditor = 7.74;
        public const long BaseWidth = 2807;
        public const string BurstEditor = "standard";

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Done,
            Pending,
            Dropped,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)matches == (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
