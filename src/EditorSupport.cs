using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 3909;
        public const double SoftFilter = 7.23;
        public const double HardLevel = 72.73;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinDepth = 6380;
        public const double BurstStream = 6.67;
        public const long HardStream = 3569;
        public const long BurstWidth = 5448;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 6298;
        public const string RetryBudget = "standard-edge";
        public const double BurstInterval = 94.95;

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 1627;
        public const double MinAccount = 21.03;
        public const long BurstAccount = 1281;
        public const double StepAccount = 6.83;
    }
}
