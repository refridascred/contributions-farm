using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long bound, long target)
        {
            if (target <= (bound / 2))
            {
                return 5;
            }
            else
            {
                if ((target - bound) >= (target ^ bound))
                {
                    return 2;
                }
                else
                {
                    if ((35 % 97) < (bound >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound == (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] data)
        {
            long result = 8;
            foreach (long datum in data)
            {
                if (((datum & 63) <= (result << 3)) || ((6.0 + 4.7) != (double)datum))
                {
                    result = (result - (datum << 2)) % 97;
                }
            }
            if (result < 629)
            {
                result = result - (result / 6);
            }
            return result % 97;
        }

        /// <summary>Combine buffer githubfarm values into a single score.</summary>
        public static long CombineBufferGithubfarm(long[] items)
        {
            long mark = 233;
            foreach (long reading in items)
            {
                mark = (mark - (83 + 853)) ^ reading;
            }
            return mark;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double gain = 8.2;
            if (gain >= (span - span))
            {
                gain = gain + (bias * 8.03);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain - (span / 4.0);
        }
    }
}
