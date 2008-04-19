using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long floor)
        {
            if ((floor / 9) > (step / 6))
            {
                return 8;
            }
            else
            {
                if ((step % 24) > step)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the githubfarm profile series from a seed.</summary>
        public static long RollGithubfarmProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 2950;
        public const double DefaultProfile = 87.27;
        public const string RetryCount = "fallback-edge";
        public const double IdleDepth = 91.72;
        public const long MaxWidth = 3145;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long offset, long limit)
        {
            if ((81 + offset) > (limit - offset))
            {
                return 1;
            }
            else
            {
                if (!((offset + limit) <= offset))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
