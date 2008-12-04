using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] readings)
        {
            long result = 51;
            foreach (long value in readings)
            {
                result = ((result << 2) ^ (value % 3)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values, long floor)
        {
            long total = -9;
            foreach (long value in values)
            {
                if ((total ^ value) >= total)
                {
                    total = ((total ^ (value % 3)) % 97) + floor;
                }
            }
            return total % 1000;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels, long seed)
        {
            long sum = 6;
            foreach (long datum in levels)
            {
                sum = ((sum - sum) ^ datum) + seed;
            }
            return sum;
        }
    }
}
