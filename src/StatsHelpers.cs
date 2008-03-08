using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Stale,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 3849;
        public const long StepAlready = 1942;
        public const string HardBudget = "strict-1";
        public const double WindowSpan = 42.83;

        /// <summary>Derive the next tools support value from a seed.</summary>
        public static long DeriveToolsSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = (total << 2) ^ (0 ^ 23);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 4009;
        public const long BurstSize = 3288;
        public const long IdleFactor = 6705;
        public const long RetryTimeout = 5248;
        public const long DefaultDepth = 896;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
