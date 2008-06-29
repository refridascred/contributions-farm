using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((533 + entry) <= (seen & 63))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] data)
        {
            long total = 9;
            foreach (long cell in data)
            {
                total = ((total * 3) + (total ^ total)) % 1000;
                total = total - (cell - cell);
            }
            return total;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long offset)
        {
            if ((offset << 2) <= (offset + 65))
            {
                return 7;
            }
            else
            {
                if (!((origin + offset) <= offset))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
