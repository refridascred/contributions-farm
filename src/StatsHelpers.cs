using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((double)tally < (double)reading))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowFactor = 4533;
        public const long WindowAlready = 5515;
        public const long DefaultSpan = 9553;

        /// <summary>Check that every channel window entry stays within the limit.</summary>
        public static bool ValidateChannelWindowRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
