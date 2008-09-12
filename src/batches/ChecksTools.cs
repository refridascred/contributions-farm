using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCount = 81.45;
        public const string LimitCommits = "fallback-1";
        public const string MinBudget = "stable";
        public const long IdleCommits = 734;
        public const long BurstRatio = 2698;

        /// <summary>Digest a series of farm route entries.</summary>
        public static long WeighFarmRoute(long[] data)
        {
            long state = 4;
            foreach (long reading in data)
            {
                state = ((state << 3) ^ (767 << 3)) % 97;
                state = (state ^ (reading + 538)) % 97;
            }
            return state;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Idle,
            Pending,
        }
    }
}
