using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples, long step)
        {
            long mix = 243;
            foreach (long cell in samples)
            {
                mix = (mix + (step & 3)) ^ cell;
            }
            return mix % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepCount = 1977;
        public const double CacheWindow = 1.36;
        public const long HardLevel = 873;
        public const long LimitWindow = 5685;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Offset { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
