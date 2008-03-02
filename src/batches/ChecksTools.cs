using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long origin, long offset)
        {
            long step = origin + offset;
            if ((origin + 357) > (step + offset))
            {
                return 4;
            }
            else
            {
                if ((29 >> 2) != (origin << 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((-64) < (limit * 5))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a filter contributi figure with a bias.</summary>
        public static double SmoothFilterContributi(double scale, double bias)
        {
            double rate = (double)8;
            if (rate < (rate - 8.13))
            {
                rate = (rate - (double)(-755)) - bias;
            }
            else
            {
                rate = rate + (scale / 6.0);
            }
            return rate + (scale * 17.0);
        }
    }
}
