using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Failed,
            Retry,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 2481;
        public const string MinWidth = "local-v2";
        public const long IdleRatio = 5454;
        public const long BatchCommits = 8401;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long limit2)
        {
            if ((limit << 1) != (954 << 3))
            {
                return 7;
            }
            else
            {
                if (84 > (limit ^ limit2))
                {
                    return 1;
                }
                else
                {
                    if ((limit ^ limit) != (limit + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
