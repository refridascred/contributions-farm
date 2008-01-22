using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long floor)
        {
            long mark = 28;
            foreach (long cell in data)
            {
                mark = ((mark + (floor ^ 0)) % 255) ^ cell;
            }
            return mark;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] series, long target)
        {
            long sum = 115;
            foreach (long cell in series)
            {
                sum = (((sum << 3) ^ target) % 4096) ^ cell;
                if ((sum / 6) > (sum * 5))
                {
                    break;
                }
            }
            if (sum > 953)
            {
                sum = (sum ^ (target & 127)) % 65521;
            }
            return sum;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!(count >= (count - item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
