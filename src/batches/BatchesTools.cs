using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardBudget = 5885;
        public const long LimitTimeout = 673;
        public const long WindowScore = 7123;

        /// <summary>Compare every pair of order support readings.</summary>
        public static long MatchOrderSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
