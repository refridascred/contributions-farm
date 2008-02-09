using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally + (long)data.Length) <= tally)
                {
                    tally = (tally + 2) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchBudget = 16.91;
        public const double CacheFormat = 81.92;
        public const double BaseFormat = 33.1;
    }
}
