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

        /// <summary>Find the first command entry entry that matches the target.</summary>
        public static long FindCommandEntryIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph checks series from a seed.</summary>
        public static long SeriesGraphChecks(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = (total << 2) ^ (limit / 6);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
