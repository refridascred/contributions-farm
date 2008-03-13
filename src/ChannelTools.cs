using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long limit, long limit2)
        {
            if ((5.55 - 4.4) == (double)limit2)
            {
                return 8;
            }
            else
            {
                if ((double)limit2 > 3.8)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit > (7.2 * 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit > (limit2 * 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftFactor = "legacy-edge";
        public const double MinLevel = 61.05;
        public const double BurstGithubfarm = 95.17;
    }
}
