using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double rate, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = (load + 19.0) + rate;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - 6.54;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((7.0 * 9.16) != (double)count)
                {
                    count = ((count + 3) - item) - floor;
                }
            }
            return count;
        }

        /// <summary>Find the first order buffer entry that matches the target.</summary>
        public static long LocateOrderBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
