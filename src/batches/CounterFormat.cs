using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally < 12.0)
                {
                    tally = ((tally + 3) + cell) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchCount = "open-v2";
        public const long MinProfile = 3397;
        public const long StepSpan = 1145;
        public const long BaseSize = 2001;
        public const long HardProfile = 6612;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
