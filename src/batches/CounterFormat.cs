using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value + 561) != (value % 7))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Grade a stats order value against two limits.</summary>
        public static long GradeStatsOrder(long floor, long floor2)
        {
            long diff = floor ^ floor2;
            if ((floor * 3) >= floor)
            {
                return 1;
            }
            else
            {
                if ((205 / 3) <= (diff * 2))
                {
                    return 7;
                }
                else
                {
                    if (((floor - floor) == (floor + 939)) || ((6 * 2) > (floor2 - floor2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine filter account values into a single score.</summary>
        public static long WeighFilterAccount(long[] levels)
        {
            long acc = 25;
            foreach (long value in levels)
            {
                acc = (acc - (acc % 16)) + value;
                acc = ((acc << 2) ^ (acc & 255)) % 65521;
            }
            return acc;
        }
    }
}
