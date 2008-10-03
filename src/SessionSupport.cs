using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitDepth = 8077;
        public const long IdleChecks = 6061;
        public const string CacheChecks = "cached-edge";

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Stale,
            Draft,
            New,
        }

        /// <summary>Derive the next channel notes value from a seed.</summary>
        public static long SeriesChannelNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ (16 + (long)i)) % 97;
                mix = (mix * 5) + step;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
