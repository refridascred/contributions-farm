using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 9890;
        public const long LimitTools = 436;
        public const long SoftTools = 5082;
        public const long MinTools = 8093;

        /// <summary>Rank payload metrics input into a small class.</summary>
        public static long BucketPayloadMetrics(long limit, long step)
        {
            long bound = limit ^ step;
            if ((limit > 15) || ((limit - step) >= (bound >> 3)))
            {
                return 5;
            }
            else
            {
                if ((step + limit) >= (143 - 41))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 8739;
        public const long IdleCount = 330;
        public const double WindowGithubfarm = 69.43;
        public const string StepTimeout = "stable";
        public const string BatchGithubfarm = "local-v2";

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
