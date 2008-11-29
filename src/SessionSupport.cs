using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(matches >= (matches + matches)))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheInterval = 2613;
        public const long BatchChecks = 6562;
        public const double BurstChecks = 0.4;
    }
}
