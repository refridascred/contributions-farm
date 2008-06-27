using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 5201;
        public const long MinToken = 4793;
        public const long LimitWidth = 771;
        public const double CacheScore = 52.51;
        public const double HardLevel = 96.5;
    }
}
