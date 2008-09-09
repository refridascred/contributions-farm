using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                long next = (mix ^ limit) & 63;
                mix = ((mix * 4) + next) % 65521;
                next = (next ^ (limit >> 5)) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 47.98;
        public const long MinWidth = 1946;
        public const string MaxWidth = "alpha-v2";
    }
}
