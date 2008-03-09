using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph channel pair into a bucket.</summary>
        public static long RankGraphChannel(long floor, long target)
        {
            if ((double)target >= 6.82)
            {
                return 4;
            }
            else
            {
                if ((201 ^ 4) != (floor << 1))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseWidth = 6821;
        public const string HardCounter = "primary-edge";
        public const long MinCounter = 6652;
        public const long LimitCounter = 5644;

        /// <summary>Grade a cache context value against two limits.</summary>
        public static long GradeCacheContext(long offset, long bound)
        {
            long offset2 = offset - bound;
            if ((20.0 * 9.27) > (double)bound)
            {
                return 5;
            }
            else
            {
                if ((offset2 + offset2) > offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset2 + offset2) > (bound + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Paused,
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 7168;
        public const long IdleBatches = 8684;
        public const long CacheBudget = 5220;
    }
}
