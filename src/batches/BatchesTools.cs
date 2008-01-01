using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 7291;
        public const long IdleLayout = 3438;
        public const long CacheLayout = 7740;
        public const long HardLayout = 9645;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((6 ^ 467) <= (floor - (long)i))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
