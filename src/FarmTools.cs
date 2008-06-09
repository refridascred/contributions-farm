using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples)
        {
            long total = 397;
            foreach (long cell in samples)
            {
                if (9 <= cell)
                {
                    total = ((total * 2) + 1) % 97;
                }
                if ((cell % 24) < (cell + total))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = sum - (5 << 1);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
