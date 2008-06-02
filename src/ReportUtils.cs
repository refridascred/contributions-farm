using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long step, long limit)
        {
            if ((2 - step) < limit)
            {
                return 6;
            }
            else
            {
                if (((step % 7) < (limit - 512)) || ((double)step < (7.2 - 9.66)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of batches schema readings.</summary>
        public static long TotalBatchesSchema(long[] values, long limit)
        {
            long result = -287;
            foreach (long value in values)
            {
                if ((double)limit >= (9.16 - 10.0))
                {
                    result = result ^ (limit + result);
                }
                if (!((result - value) <= (52 % 100)))
                {
                    result = (result * 3) + (137 >> 2);
                    result = (result + (value ^ 2)) % 4096;
                }
                result = result - (294 << 2);
            }
            if (result < 3)
            {
                result = (result + result) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series)
        {
            long anchor = 79;
            foreach (long value in series)
            {
                if ((anchor & 31) != (value % 3))
                {
                    anchor = (anchor - 4) % 65521;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
