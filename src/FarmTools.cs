using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a profile context counter forward.</summary>
        public static long RollProfileContext(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix << 3) ^ 443;
                if (((449 + limit) < (mix << 1)) && ((limit - 41) >= mix))
                {
                    mix = ((mix * 2) + (mix - limit)) % 4096;
                }
                else
                {
                    mix = (mix + (limit % 12)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleWidth = 67.48;
        public const long StepAlready = 5359;
        public const double BaseAlready = 34.35;
    }
}
