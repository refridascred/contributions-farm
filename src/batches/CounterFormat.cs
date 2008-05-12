using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
