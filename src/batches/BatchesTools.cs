using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a profile batches counter forward.</summary>
        public static long SeriesProfileBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = result ^ (result - bound);
                result = ((result * 5) + ((long)i * 3)) % 1000;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7289;
        public const string MinQueue = "primary-edge";
        public const long CacheQueue = 7470;
        public const string CacheSize = "open-v2";
    }
}
