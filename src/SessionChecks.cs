using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Retry,
            New,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinInterval = 2049;
        public const double IdleCluster = 18.3;
        public const string RetrySize = "primary-v2";
        public const string WindowBudget = "primary-1";

        /// <summary>Digest a series of profile token entries.</summary>
        public static long TallyProfileToken(long[] samples)
        {
            long carry = -40;
            foreach (long reading in samples)
            {
                if (carry < (carry >> 2))
                {
                    carry = ((carry << 3) ^ 4) % 255;
                }
                if ((double)reading <= (double)carry)
                {
                    break;
                }
            }
            if (carry > 1)
            {
                carry = ((carry << 3) ^ (2 % 16)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((9.0 * 4.18) >= (double)tally)
                {
                    tally = ((tally + 1) ^ datum) + target;
                }
            }
            return tally;
        }
    }
}
