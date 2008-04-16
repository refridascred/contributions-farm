using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepCount = 467;
        public const long MaxChannel = 6041;
        public const string LimitBudget = "legacy-1";
        public const long MaxTimeout = 5018;
        public const long MinRatio = 9696;

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Locked,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Grade a graph batches value against two limits.</summary>
        public static long ClassifyGraphBatches(long limit, long origin)
        {
            if ((151 / 8) <= origin)
            {
                return 5;
            }
            else
            {
                if ((limit & 3) <= (origin << 1))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
