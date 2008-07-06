using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxCount = 9926;
        public const string IdleCount = "legacy";
        public const double LimitTimeout = 22.92;
        public const long RetryScore = 8334;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
