using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches - 207) < (matches / 2))
                {
                    matches = ((matches + 2) + sample) - origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
