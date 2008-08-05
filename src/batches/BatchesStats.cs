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

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values)
        {
            long mix = 4;
            foreach (long datum in values)
            {
                if ((196 * 4) < (mix + mix))
                {
                    mix = ((mix << 3) ^ (25 - mix)) + datum;
                }
            }
            return mix;
        }
    }
}
