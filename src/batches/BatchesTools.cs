using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Rank { get; set; }
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardWidth = 9013;
        public const long RetrySpan = 3121;
        public const long DefaultFactor = 5225;
        public const string HardGraph = "open-v2";
        public const long RetryGraph = 5153;
    }
}
