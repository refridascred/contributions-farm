using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 97.11;
        public const double WindowReport = 42.54;
        public const long MinReport = 4614;
        public const long MaxReport = 8811;

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples)
        {
            long anchor = 89;
            foreach (long reading in samples)
            {
                anchor = ((anchor + anchor) % 4096) + reading;
            }
            return anchor;
        }
    }
}
