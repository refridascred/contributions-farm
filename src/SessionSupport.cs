using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 2769;
        public const string CacheInterval = "standard";
        public const double MinChannel = 73.24;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) >= (966 & 1))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }
    }
}
