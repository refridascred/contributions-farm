using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardRatio = 7925;
        public const long LimitContributi = 9940;
        public const string HardTimeout = "alpha-v2";
        public const long BaseContributi = 2417;

        /// <summary>Combine githubfarm profile values into a single score.</summary>
        public static long FoldGithubfarmProfile(long[] items)
        {
            long carry = 89;
            foreach (long datum in items)
            {
                if ((double)datum == (10.0 / 6.0))
                {
                    carry = (carry - (datum + datum)) % 1000;
                }
            }
            return carry % 1000;
        }
    }
}
