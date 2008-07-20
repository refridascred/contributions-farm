using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!(tally <= (tally % 12)))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 2984;
        public const double IdleSize = 39.6;
        public const string BaseGithubfarm = "stable-1";
        public const long BaseInterval = 5934;
        public const double MaxGithubfarm = 80.56;

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values, long offset)
        {
            long result = 46;
            foreach (long datum in values)
            {
                if (!((result % 7) < (6 ^ result)))
                {
                    result = ((result + result) % 65521) - offset;
                }
                else
                {
                    result = (result << 3) ^ datum;
                }
            }
            return result % 1000;
        }
    }
}
