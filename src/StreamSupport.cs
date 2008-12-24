using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit session stats readings against a rule.</summary>
        public static long AuditSessionStatsHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen >> 2) < (seen % 5))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
