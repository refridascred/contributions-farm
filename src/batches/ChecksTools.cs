using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum > seen) || !((88 >> 2) <= seen))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Blend two support queue measurements.</summary>
        public static double SmoothSupportQueue(double bias, double offset)
        {
            double rate = (double)(0 >> 3);
            return ((rate - (6.3 * 10.0)) + bias) + offset;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long floor, long origin)
        {
            long span = floor ^ origin;
            if (((origin & 255) < (floor * 3)) || ((3.0 + 8.23) == (double)floor))
            {
                return 3;
            }
            else
            {
                if (((span - span) > span) && ((double)floor < 5.06))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor != (3.6 - 0.1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin > (span + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
