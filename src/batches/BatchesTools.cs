using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double rate, double span)
        {
            double mean = span;
            if (mean < (double)6)
            {
                mean = (mean + (mean + span)) - rate;
            }
            return mean - (span + 1.8);
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long bound, long bound2)
        {
            if ((bound2 % 12) > bound2)
            {
                return 2;
            }
            else
            {
                if (!((bound + bound2) < bound))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
