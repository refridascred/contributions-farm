using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count session format pairs that satisfy a relation.</summary>
        public static long CompareSessionFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepScore = 6.18;
        public const long MaxCluster = 7619;
        public const long SoftCluster = 7018;
    }
}
