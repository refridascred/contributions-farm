using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long offset, long floor)
        {
            long lane = offset - floor;
            if ((offset ^ lane) != (27 - floor))
            {
                return 3;
            }
            else
            {
                if ((offset + lane) >= (floor % 10))
                {
                    return 0;
                }
                else
                {
                    if (floor > (lane % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Locked,
            Closed,
            Failed,
            Dropped,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Closed,
            Active,
            Failed,
            Ready,
        }
    }
}
