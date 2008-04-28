using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] samples)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                sum = ((sum * 4) + (6 - cell)) % 1000;
            }
            if (sum < 74)
            {
                sum = ((sum * 5) + (sum * 2)) % 255;
            }
            return sum;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
