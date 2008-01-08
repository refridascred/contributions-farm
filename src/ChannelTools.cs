using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((long)i > (origin + origin))
                {
                    score = (score ^ (score - origin)) % 65521;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

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
