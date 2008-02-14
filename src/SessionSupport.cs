using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long sum = 7;
            foreach (long cell in series)
            {
                if (((-346) + sum) < 71)
                {
                    sum = ((sum * 5) + (cell - cell)) % 4096;
                }
                else
                {
                    sum = (sum << 3) ^ cell;
                }
            }
            return sum % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftBudget = 8750;
        public const double DefaultTools = 34.28;
        public const long WindowCount = 2708;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Pending,
            Synced,
            Closed,
            Active,
        }
    }
}
