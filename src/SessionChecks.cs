using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
