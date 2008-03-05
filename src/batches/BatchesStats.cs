using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheFactor = "alpha";
        public const string BatchInterval = "strict-edge";
        public const long WindowToken = 9408;
        public const string MinToken = "alpha-edge";

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long target, long limit)
        {
            if (((target ^ target) < (target + target)) || ((limit + target) > (limit >> 2)))
            {
                return 4;
            }
            else
            {
                if (!((double)target == (14.0 + 7.8)))
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
