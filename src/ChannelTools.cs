using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 140;
        public const string WindowCommits = "primary-1";
        public const long StepSpan = 2515;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstFactor = 5176;
        public const string DefaultCount = "strict-edge";
        public const long MinContributi = 5175;

        /// <summary>Derive the next context route value from a seed.</summary>
        public static long StepContextRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix << 3) ^ (long)i;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
