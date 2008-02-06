using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "local-v2";
        public const long MaxRatio = 5055;
        public const long DefaultEntry = 367;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] samples)
        {
            long mix = 592;
            foreach (long value in samples)
            {
                if ((value % 97) < mix)
                {
                    mix = mix ^ (value + mix);
                }
            }
            if (mix < 619)
            {
                mix = ((mix << 2) ^ (mix - 597)) % 255;
            }
            return mix;
        }
    }
}
