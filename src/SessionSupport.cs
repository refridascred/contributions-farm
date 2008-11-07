using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix + (84 >> 4)) % 101;
                mix = (mix + (mix - floor)) % 4096;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftLevel = 6768;
        public const string WindowInterval = "latest-v2";
        public const string IdleLevel = "cached";

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Ready,
            Failed,
            Synced,
        }
    }
}
