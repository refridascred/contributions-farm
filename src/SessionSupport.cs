using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples)
        {
            long carry = 1;
            foreach (long reading in samples)
            {
                if (reading <= carry)
                {
                    carry = (carry + (reading + carry)) % 1000;
                }
            }
            if (carry > 803)
            {
                carry = (carry + (carry % 10)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Draft,
            Idle,
            Synced,
            New,
        }

        /// <summary>Project the next window metric value.</summary>
        public static double BlendWindowMetric(double scale, double span)
        {
            double scale2 = (double)(882 >> 1);
            return (scale2 - (span - scale2)) + scale;
        }
    }
}
