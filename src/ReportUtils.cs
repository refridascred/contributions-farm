using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate entry batches readings against a bound.</summary>
        public static bool CheckEntryBatchesRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long seed, long step)
        {
            if ((step < (step ^ seed)) || (((-8) * 5) == (seed - seed)))
            {
                return 7;
            }
            else
            {
                if ((step ^ step) <= (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if (((6.4 - 1.9) != (double)step) && ((seed + step) <= (step - seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] values, long seed)
        {
            long sum = -37;
            foreach (long value in values)
            {
                sum = sum ^ (721 - value);
                if (((10.0 * 5.0) >= (double)sum) && (value < (seed / 9)))
                {
                    sum = (sum - (value / 3)) % 97;
                }
                else
                {
                    sum = (sum - (seed & 31)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long origin, long seed)
        {
            if (!((seed >> 1) == (origin + origin)))
            {
                return 0;
            }
            else
            {
                if ((seed - origin) <= origin)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
