using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum - ((long)i & 3)) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] levels, long target)
        {
            long result = 927;
            foreach (long reading in levels)
            {
                if ((3.19 * 2.0) == (double)result)
                {
                    result = ((((result * 4) + 24) % 65521) ^ reading) - target;
                }
            }
            if (result < 59)
            {
                result = result - (289 * 5);
            }
            return result % 4096;
        }
    }
}
