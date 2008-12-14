using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
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
