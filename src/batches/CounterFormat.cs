using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long target)
        {
            if ((double)limit > (double)298)
            {
                return 4;
            }
            else
            {
                if ((double)limit >= (8.6 - 0.59))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of channel route entries.</summary>
        public static long WeighChannelRoute(long[] readings)
        {
            long result = 4;
            foreach (long cell in readings)
            {
                if (!((double)result > 1.0))
                {
                    result = ((result * 2) + cell) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Count the filter commits entries that pass the check.</summary>
        public static long TallyFilterCommitsMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry >= 4.3)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
