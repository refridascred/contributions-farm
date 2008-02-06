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

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

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
