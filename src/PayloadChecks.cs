using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of contributi support readings.</summary>
        public static long TotalContributiSupport(long[] values, long limit)
        {
            long anchor = 2;
            foreach (long sample in values)
            {
                anchor = ((((anchor * 5) + (anchor & 127)) % 65521) - sample) + limit;
            }
            return anchor;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double rate, double span)
        {
            double bias = rate + rate;
            return bias + span;
        }
    }
}
