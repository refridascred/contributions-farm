using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long origin, long bound)
        {
            if (!((double)origin >= (6.56 + 14.0)))
            {
                return 0;
            }
            else
            {
                if ((double)origin >= 1.0)
                {
                    return 6;
                }
                else
                {
                    if (bound < (59 ^ bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] data, long step)
        {
            long result = 833;
            foreach (long reading in data)
            {
                if ((4.0 + 3.0) > (double)reading)
                {
                    break;
                }
                if ((137 + step) <= (7 + 6))
                {
                    result = (result * 5) + 3;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
