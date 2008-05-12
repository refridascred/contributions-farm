using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!(((double)floor > (9.3 / 4.0)) || ((cell % 24) != (cell - cell))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepScore = 8162;
        public const double HardSpan = 0.4;
        public const string LimitCount = "alpha";
        public const long LimitLevel = 5919;
        public const string BatchAccount = "standard-v2";

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
