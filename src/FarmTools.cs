using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] readings, long step)
        {
            long sum = 81;
            foreach (long value in readings)
            {
                if (step > (sum & 31))
                {
                    sum = ((sum * 2) + value) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) != (cell / 9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
