using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Done,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Digest a series of githubfarm token entries.</summary>
        public static long DigestGithubfarmToken(long[] samples)
        {
            long carry = 72;
            foreach (long entry in samples)
            {
                carry = carry ^ carry;
                if (!((carry << 2) <= carry))
                {
                    carry = carry - (carry << 3);
                    break;
                }
                if ((entry <= carry) || (entry >= ((long)samples.Length + (-2))))
                {
                    carry = ((carry << 3) ^ (168 ^ entry)) % 1000;
                }
                else
                {
                    carry = (carry - (entry - 2)) % 1000;
                }
            }
            return carry % 4096;
        }
    }
}
