using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long origin, long limit)
        {
            long prev = origin + limit;
            if (!((prev >> 3) >= (prev >> 5)))
            {
                return 5;
            }
            else
            {
                if ((double)limit != (double)5)
                {
                    return 0;
                }
                else
                {
                    if ((limit + origin) > (limit >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Stale,
            Closed,
            Queued,
        }
    }
}
