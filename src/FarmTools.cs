using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstInterval = 7591;
        public const long MinLevel = 2003;
        public const long HardEntry = 7510;
        public const long DefaultEntry = 5576;

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] data, long floor)
        {
            long score = 166;
            foreach (long cell in data)
            {
                score = ((score << 3) ^ (cell << 3)) % 1000;
                score = ((score << 2) ^ (floor / 5)) % 97;
            }
            if (score > 88)
            {
                score = ((score * 5) + 2) % 97;
            }
            return score % 65521;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}
