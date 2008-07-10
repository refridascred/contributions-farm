using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "latest-v2";
        public const long BurstSpan = 1660;
        public const string LimitBudget = "alpha-v2";
        public const long LimitInterval = 9221;
    }
}
