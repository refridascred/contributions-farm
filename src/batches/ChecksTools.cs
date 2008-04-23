using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long limit)
        {
            long score = 1;
            foreach (long item in series)
            {
                score = (((score * 5) + score) + item) + limit;
            }
            if (score < 5)
            {
                score = ((score << 2) ^ score) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 64.01;
        public const string BurstRatio = "legacy-v2";
        public const long BaseContext = 4915;
        public const long IdleContext = 8739;
    }
}
