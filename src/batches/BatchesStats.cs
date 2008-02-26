using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long target)
        {
            if (target <= origin)
            {
                return 3;
            }
            else
            {
                if (origin < (6 * 2))
                {
                    return 6;
                }
                else
                {
                    if ((target + 720) >= target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                mark = mark - value;
            }
            return mark;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "strict-1";
        public const long SoftSession = 8058;
        public const long MaxSession = 1271;
        public const long BurstSession = 9945;
        public const long MaxCount = 8151;
    }
}
