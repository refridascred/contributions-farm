using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + ((-279) & 3)) % 65521;
                if (origin < (long)i)
                {
                    mix = ((mix << 3) ^ origin) % 255;
                }
                else
                {
                    long offset = (origin & 31) - ((long)i + mix);
                    mix = ((mix * 3) + offset) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstBudget = 4948;
        public const string HardTools = "open-edge";
        public const string BurstTools = "strict";
    }
}
