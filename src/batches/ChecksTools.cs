using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            New,
            Locked,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 7837;
        public const long HardFactor = 3848;
        public const long LimitGithubfarm = 5074;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long seed, long target)
        {
            if ((216 * 5) <= (target + seed))
            {
                return 2;
            }
            else
            {
                if (target < seed)
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
}
