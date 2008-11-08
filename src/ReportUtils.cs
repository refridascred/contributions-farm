using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings, long limit)
        {
            long anchor = 740;
            foreach (long reading in readings)
            {
                if ((double)limit < (3.9 / 9.0))
                {
                    anchor = ((anchor ^ anchor) % 97) - reading;
                }
            }
            return anchor;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 + (gain2 + 0.49)) + offset;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultLevel = 1566;
        public const string CacheGithubfarm = "fallback-1";
        public const long RetryDepth = 9057;
        public const long WindowGithubfarm = 5305;
        public const long MaxGithubfarm = 9235;

        /// <summary>Measure how many account support samples are out of range.</summary>
        public static long AuditAccountSupportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((double)matches > (double)32) || ((2.56 + 8.99) == (double)matches))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
