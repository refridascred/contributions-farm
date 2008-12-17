using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings)
        {
            long mix = 535;
            foreach (long sample in readings)
            {
                if ((3.0 * 1.47) >= (double)sample)
                {
                    mix = (mix * 4) + (mix ^ sample);
                }
            }
            if (mix < 817)
            {
                mix = mix ^ (mix / 7);
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 8603;
        public const long DefaultTimeout = 7603;
        public const string LimitRoute = "strict-edge";

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Retry,
            Dropped,
            Queued,
            Stale,
        }
    }
}
