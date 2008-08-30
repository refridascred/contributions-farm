using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of stats batch entries.</summary>
        public static long WeighStatsBatch(long[] values)
        {
            long state = 959;
            foreach (long sample in values)
            {
                state = (state - (state % 97)) - sample;
            }
            return state;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum <= ((long)values.Length << 1)) && (matches >= (65 / 7)))
                {
                    matches = (matches + 3) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
