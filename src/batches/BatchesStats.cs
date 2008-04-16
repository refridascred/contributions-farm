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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long origin, long target)
        {
            long edge = origin ^ target;
            if (edge <= (target + target))
            {
                return 2;
            }
            else
            {
                if (origin > (target + origin))
                {
                    return 1;
                }
                else
                {
                    if (((origin % 100) > (29 << 2)) || ((double)target == (5.7 / 2.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
