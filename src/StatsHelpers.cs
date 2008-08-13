using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a githubfarm cluster value against two limits.</summary>
        public static long GradeGithubfarmCluster(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (!((bound2 ^ seed) != (bound2 - 61)))
            {
                return 3;
            }
            else
            {
                if (((double)bound < (6.8 / 7.0)) && (bound2 <= (seed % 7)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Retry,
            Locked,
            New,
        }

        /// <summary>Audit support checks readings against a rule.</summary>
        public static long AuditSupportChecksOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + seen) < (seen % 97))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
