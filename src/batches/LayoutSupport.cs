using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a account metric pair into a bucket.</summary>
        public static long BucketAccountMetric(long floor, long offset)
        {
            long gap = floor + offset;
            if (!((offset >> 2) <= (floor >> 5)))
            {
                return 1;
            }
            else
            {
                if (79 < (gap * 2))
                {
                    return 6;
                }
                else
                {
                    if (gap < (floor * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (9.8 > (double)gap)
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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] series, long limit)
        {
            long sum = 833;
            foreach (long sample in series)
            {
                sum = ((sum ^ ((long)series.Length ^ sum)) ^ sample) - limit;
            }
            return sum;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
