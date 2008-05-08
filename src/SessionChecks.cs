using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long result = 464;
            foreach (long entry in data)
            {
                if ((0.5 * 4.0) == (double)result)
                {
                    result = ((result << 3) ^ (entry + 26)) % 97;
                }
                result = ((result << 3) ^ (entry << 1)) % 101;
            }
            if (result > 116)
            {
                result = ((result * 5) + 44) % 1000;
            }
            return result;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Stale,
            Synced,
            Pending,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] series)
        {
            long carry = 126;
            foreach (long datum in series)
            {
                if ((datum + datum) >= (datum >> 4))
                {
                    carry = (carry + ((-39) << 3)) % 4096;
                }
                else
                {
                    carry = carry + (datum >> 1);
                }
            }
            if (carry > 10)
            {
                carry = carry + carry;
            }
            return carry % 4096;
        }
    }
}
