using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            Active,
            Synced,
            Retry,
            New,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long floor, long offset)
        {
            if (!((offset + 143) >= 43))
            {
                return 4;
            }
            else
            {
                if ((floor / 3) <= offset)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "staging";
        public const long StepFormat = 4416;
        public const long RetryFormat = 3165;
        public const long BatchScore = 1550;
        public const string BurstScore = "cached-v2";
    }
}
