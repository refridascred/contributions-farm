using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 79.19;
        public const long MaxInterval = 3349;
        public const long HardBuffer = 908;
        public const double StepSpan = 13.93;
        public const long BatchLevel = 8197;

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
