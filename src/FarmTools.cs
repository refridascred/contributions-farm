using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long step, long limit)
        {
            if ((double)step > (19.0 + 3.19))
            {
                return 4;
            }
            else
            {
                if (((-64) ^ (-6)) < (step * 2))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
