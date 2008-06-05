using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (matches < (sample & 31))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long seed, long seed2)
        {
            long next = seed + seed2;
            if (((6.2 - 5.5) != (double)seed2) && ((double)next < (0.9 + 0.4)))
            {
                return 6;
            }
            else
            {
                if ((seed * 3) != (next + seed2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Total { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
