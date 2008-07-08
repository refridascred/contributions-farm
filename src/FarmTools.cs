using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long origin)
        {
            if (!((916 + step) <= step))
            {
                return 7;
            }
            else
            {
                if ((step & 31) > (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (step >= origin)
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

        /// <summary>Define command limits and defaults.</summary>
        public const long MinInterval = 1008;
        public const long MaxCommand = 1678;
        public const string RetryFactor = "standard-v2";
        public const long IdleRatio = 931;
    }
}
