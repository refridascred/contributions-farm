using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "fallback-edge";
        public const double BaseScore = 69.47;
        public const long DefaultLevel = 4601;
        public const long LimitCommits = 5012;

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 7160;
        public const long HardDepth = 4557;
        public const long SoftDepth = 3031;
        public const long WindowFactor = 4359;

        /// <summary>Check that every support githubfarm entry stays within the limit.</summary>
        public static bool GuardSupportGithubfarmBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
