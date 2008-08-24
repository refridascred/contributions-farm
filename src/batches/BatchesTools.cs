using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchDepth = 1720;
        public const long WindowSpan = 7057;
        public const long RetryBatches = 3775;
        public const double LimitSpan = 50.03;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long step, long step2)
        {
            if ((double)step >= 5.1)
            {
                return 1;
            }
            else
            {
                if (((step2 + step) != (719 - step)) || ((step2 + step) > step2))
                {
                    return 6;
                }
                else
                {
                    if (step2 <= (step2 << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
