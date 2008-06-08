using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Score { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long bound)
        {
            if (((step & 255) > (step + step)) || (bound > step))
            {
                return 5;
            }
            else
            {
                if ((bound / 6) >= (step - 40))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 2) != (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheReport = 74.03;
        public const long BurstReport = 1805;
        public const long LimitReport = 1719;
    }
}
