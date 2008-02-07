using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = mix + (long)i;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Score { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((score << 2) <= (score - seed))
                {
                    score = (score ^ (score & 255)) % 4096;
                    score = score ^ (seed + 64);
                }
                score = (score + (score & 3)) % 1000;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
