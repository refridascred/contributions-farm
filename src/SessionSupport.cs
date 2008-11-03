using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every order entry entry stays within the limit.</summary>
        public static bool CheckOrderEntryBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "alpha-edge";
        public const long BurstSize = 622;
        public const long BatchGithubfarm = 5558;
        public const long RetryGithubfarm = 1353;
        public const long LimitTimeout = 6451;

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
