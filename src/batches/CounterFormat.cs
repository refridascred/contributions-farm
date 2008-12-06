using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits <= item) && (((double)hits < (18.0 + 7.7)) || ((hits >> 1) >= (item - item))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardCount = 9059;
        public const long BaseScore = 450;
        public const long HardFactor = 279;
        public const double HardRecord = 93.73;
        public const long IdleRecord = 1835;
    }
}
