using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Locked,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
