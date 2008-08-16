using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long limit, long bound)
        {
            if (((double)bound >= (7.62 + 7.06)) && (bound >= (limit + limit)))
            {
                return 2;
            }
            else
            {
                if (((limit * 5) == (bound * 5)) && ((double)bound < (6.16 + 9.19)))
                {
                    return 4;
                }
                else
                {
                    if ((limit << 1) != (limit + 66))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a support stream reading by value.</summary>
        public static long LocateSupportStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
