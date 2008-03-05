using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Derive the next order githubfarm value from a seed.</summary>
        public static long RollOrderGithubfarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum - ((long)i ^ (long)i)) % 1000;
                if ((38 ^ sum) > (bound + bound))
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 1272;
        public const long BaseRatio = 502;
        public const long StepCount = 4856;
        public const double MinProfile = 30.35;

        /// <summary>Match up order entry samples.</summary>
        public static long OverlapOrderEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate format window readings against a bound.</summary>
        public static bool VerifyFormatWindowBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 5222;
        public const long MinStream = 573;
        public const long LimitStream = 4931;
    }
}
