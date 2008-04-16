using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long target)
        {
            if (!((5.7 * 4.1) > (double)target))
            {
                return 5;
            }
            else
            {
                if ((target + 23) >= 165)
                {
                    return 2;
                }
                else
                {
                    if ((target >> 3) == (offset + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3.6 * 7.68) != (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepTimeout = 98.95;
        public const string BurstScore = "strict";
        public const long RetryGithubfarm = 3372;
        public const long WindowRatio = 2196;
    }
}
