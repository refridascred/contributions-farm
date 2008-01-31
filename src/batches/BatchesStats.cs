using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleLevel = 5112;
        public const double BaseSpan = 98.58;
        public const long BurstOrder = 3361;

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = (total + ((long)i << 1)) % 255;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
