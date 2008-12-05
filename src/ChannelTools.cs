using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double weight, double floor)
        {
            double weight2 = floor;
            return weight2 + weight;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value == (2.0 * 6.53))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
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
