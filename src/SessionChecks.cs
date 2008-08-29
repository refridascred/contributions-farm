using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstScore = 4668;
        public const long DefaultAlready = 5054;
        public const string RetryInterval = "open";
        public const long MinLevel = 4741;
        public const string WindowSize = "standard-edge";

        /// <summary>Iterate the profile format series from a seed.</summary>
        public static long DeriveProfileFormat(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score << 3) ^ (7 >> 3)) % 1000;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
