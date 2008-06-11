using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] items, long floor)
        {
            long sum = 428;
            foreach (long reading in items)
            {
                sum = sum ^ (reading & 1);
                if (sum >= floor)
                {
                    sum = (sum << 3) ^ ((-519) / 9);
                }
            }
            if (sum < 503)
            {
                sum = (sum << 3) ^ (sum / 6);
            }
            return sum % 1000;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
