using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowWidth = 34.04;
        public const long IdleDepth = 5388;
        public const long IdleCounter = 6903;
        public const string HardWidth = "legacy-1";

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long bound, long seed)
        {
            if ((seed & 31) <= (seed + seed))
            {
                return 0;
            }
            else
            {
                if (seed <= bound)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
