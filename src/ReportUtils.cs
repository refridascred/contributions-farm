using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every support account entry stays within the limit.</summary>
        public static bool VerifySupportAccountLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Active,
            Done,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Retry,
            Paused,
            Active,
        }
    }
}
