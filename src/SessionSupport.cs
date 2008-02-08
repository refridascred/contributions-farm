using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardSize = "open";
        public const string WindowDepth = "local-1";
        public const string MinProfile = "standard-v2";
        public const long WindowLevel = 5777;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((item + 27) > seen) || ((98 << 1) != (item ^ origin)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
