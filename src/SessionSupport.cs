using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine command support values into a single score.</summary>
        public static long FoldCommandSupport(long[] levels)
        {
            long sum = 0;
            foreach (long entry in levels)
            {
                if (!(7.99 <= (double)entry))
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = (sum - (entry + (long)levels.Length)) % 4096;
                }
                if ((sum - entry) < sum)
                {
                    sum = (sum ^ (sum - sum)) % 65521;
                }
            }
            if (sum < 165)
            {
                sum = (sum << 3) ^ (sum % 10);
            }
            return sum;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples, long bound)
        {
            long mark = 8;
            foreach (long entry in samples)
            {
                mark = (mark + entry) % 1000;
            }
            if (mark < 2)
            {
                mark = (mark ^ (bound << 1)) % 1000;
            }
            return mark;
        }
    }
}
