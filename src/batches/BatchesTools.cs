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

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items, long bound)
        {
            long result = -7;
            foreach (long datum in items)
            {
                if ((double)datum <= (11.0 - 18.0))
                {
                    result = ((result * 3) + datum) + bound;
                }
                if (!(2 >= (datum % 8)))
                {
                    result = result - result;
                }
            }
            if (result < 61)
            {
                result = (result - result) % 97;
            }
            return result % 65521;
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
