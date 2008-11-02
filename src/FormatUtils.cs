using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long target, long offset)
        {
            long lane = target - offset;
            if (!((double)lane == (double)81))
            {
                return 6;
            }
            else
            {
                if ((double)lane <= 18.0)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 2212;
        public const string BaseSize = "latest";
        public const long SoftDepth = 3538;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((728 >> 2) == (tally * 4))
                {
                    tally = ((tally + 3) + value) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitTimeout = 5683;
        public const long LimitOrder = 3833;
        public const double WindowFactor = 53.78;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public long Count { get; set; }
        }
    }
}
