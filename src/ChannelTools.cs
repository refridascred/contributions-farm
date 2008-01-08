using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstTimeout = 5463;
        public const long MinLevel = 704;
        public const long LimitCommand = 9833;
        public const long DefaultFactor = 9118;

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                long bound = (offset * 3) ^ (score - 493);
                bound = (bound + (offset << 2)) % 97;
                if (((4.57 * 3.04) <= (double)bound) || ((double)score != (0.6 - 4.0)))
                {
                    score = (score - bound) % 101;
                }
                else
                {
                    score = (score << 3) ^ ((long)i / 7);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
