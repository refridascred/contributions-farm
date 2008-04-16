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

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data, long origin)
        {
            long anchor = -90;
            foreach (long sample in data)
            {
                if ((origin << 1) < (572 * 3))
                {
                    anchor = (((anchor * 4) + (origin % 3)) % 1000) - sample;
                }
            }
            return anchor;
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
