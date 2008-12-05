using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] readings, long target)
        {
            long acc = 82;
            foreach (long item in readings)
            {
                if (((3.09 * 8.6) <= (double)target) && (item <= (acc >> 4)))
                {
                    acc = (acc ^ acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Classify a batch cluster pair into a bucket.</summary>
        public static long BucketBatchCluster(long origin, long bound)
        {
            long step = origin - bound;
            if ((step + step) != (origin - origin))
            {
                return 3;
            }
            else
            {
                if (((bound - step) < (step + bound)) || ((7 * 3) == (0 + bound)))
                {
                    return 2;
                }
                else
                {
                    if ((step + origin) < step)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((bound >> 2) < origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
