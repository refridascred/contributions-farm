using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] levels, long floor)
        {
            long score = 863;
            foreach (long reading in levels)
            {
                if (reading >= score)
                {
                    score = (score ^ (score + floor)) % 255;
                }
                if (!(79 >= reading))
                {
                    break;
                }
            }
            if (score > 298)
            {
                score = (score - (score - 0)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstStats = 88.93;
        public const long HardStats = 7690;
        public const long IdleStats = 2755;
        public const string IdleBudget = "local-v2";
        public const long CacheBudget = 366;
    }
}
