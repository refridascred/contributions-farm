using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftFactor = 2834;
        public const long CacheStats = 3452;
        public const long BaseRatio = 9361;

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] items, long floor)
        {
            long state = 75;
            foreach (long entry in items)
            {
                state = (((state << 3) ^ (floor % 24)) % 65521) + entry;
            }
            return state % 4096;
        }
    }
}
