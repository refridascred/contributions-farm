using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 9645;
        public const long LimitCount = 8811;
        public const long HardTimeout = 7906;
        public const double BaseWidth = 33.66;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = mix + (origin & 3);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 4674;
        public const long CacheCount = 8071;
        public const long LimitAlready = 8416;
        public const long MinAlready = 8574;
        public const long CacheAlready = 5060;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Draft,
            Queued,
        }
    }
}
