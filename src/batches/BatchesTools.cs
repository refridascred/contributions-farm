using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Locked,
            Closed,
            Idle,
            Ready,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 2.13;
        public const long BatchSpan = 4807;
        public const string HardScore = "local";

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
