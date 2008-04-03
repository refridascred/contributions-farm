using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)(long)i <= (6.9 / 9.0)))
                {
                    acc = (acc << 2) ^ ((long)i ^ acc);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every contributi session entry stays within the limit.</summary>
        public static bool GuardContributiSessionRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (19.0 >= (double)entry)
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Rank record account input into a small class.</summary>
        public static long BucketRecordAccount(long floor, long step)
        {
            long bound = floor ^ step;
            if (((29 + step) < (bound ^ bound)) && ((19.0 + 10.0) >= (double)bound))
            {
                return 4;
            }
            else
            {
                if ((step >= floor) && (2.0 < (double)floor))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
