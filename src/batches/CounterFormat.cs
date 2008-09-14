using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the githubfarm filter series from a seed.</summary>
        public static long DeriveGithubfarmFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchWidth = 4731;
        public const string HardOrder = "primary";
        public const long WindowCount = 517;
        public const long CacheOrder = 342;
        public const string BaseOrder = "alpha";
    }
}
