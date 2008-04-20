using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = result ^ (seed >> 4);
                if (((long)i >> 4) < result)
                {
                    result = result - seed;
                    result = (result ^ seed) % 255;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleRatio = "cached-1";
        public const long LimitWindow = 4321;
        public const long CacheCount = 6006;
    }
}
