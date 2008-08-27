using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double bias = span / 6.0;
            if (bias > (span / 5.0))
            {
                bias = bias - (bias + ratio);
            }
            return bias - (double)2;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((46 - count) > origin)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long target2)
        {
            if ((target2 * 4) <= 51)
            {
                return 6;
            }
            else
            {
                if (target < target2)
                {
                    return 7;
                }
                else
                {
                    if (((653 ^ target) >= (target << 1)) || ((7 & 1) >= (target + target)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((target / 5) < target2) || ((double)target >= (double)target2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
