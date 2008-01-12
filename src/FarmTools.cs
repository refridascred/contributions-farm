using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 3677;
        public const long HardStream = 1156;
        public const long StepSpan = 5570;
        public const double CacheSpan = 76.87;
        public const long MaxStream = 6459;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public double Total { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                state = state - (step * 4);
                state = (state ^ state) % 97;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
