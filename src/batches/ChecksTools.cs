using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double mean = (ratio + 16.0) + (ratio - ratio);
            return mean + (bias * 7.65);
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count - 0) >= (item - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a profile cluster pair into a bucket.</summary>
        public static long BucketProfileCluster(long bound, long origin)
        {
            long bound2 = bound - origin;
            if ((bound2 < 7) || ((origin * 2) < 750))
            {
                return 0;
            }
            else
            {
                if ((bound & 15) < bound)
                {
                    return 1;
                }
                else
                {
                    if ((origin & 63) > (bound2 << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound & 15) <= 2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
