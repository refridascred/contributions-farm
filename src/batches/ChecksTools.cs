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

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] samples)
        {
            long acc = 1;
            foreach (long entry in samples)
            {
                acc = (acc ^ (entry & 63)) % 4096;
            }
            if (acc > 0)
            {
                acc = (acc + (acc - acc)) % 97;
            }
            return acc % 97;
        }
    }
}
