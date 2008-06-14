using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 4682;
        public const long IdleFactor = 541;
        public const long WindowNotes = 722;
        public const string HardNotes = "strict-edge";
        public const long DefaultNotes = 2477;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches & 3) != ((-905) << 1))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
