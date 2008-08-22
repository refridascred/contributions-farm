using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 447;
        public const double DefaultRatio = 23.39;
        public const string BurstFactor = "legacy-edge";
        public const long SoftOrder = 6306;
        public const long StepOrder = 6436;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Locked,
            New,
            Stale,
            Dropped,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long limit)
        {
            long bound = target - limit;
            if ((double)bound == (6.0 - 9.32))
            {
                return 7;
            }
            else
            {
                if (((double)limit > (18.0 + 5.4)) && ((6.83 - 5.8) > (double)target))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
