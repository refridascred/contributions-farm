using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)tally >= (0.9 / 4.0)) && ((double)bound == (3.0 / 6.0)))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] values)
        {
            long state = 362;
            foreach (long item in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (state + 6) + (long)i;
                }
                if ((double)item >= 3.9)
                {
                    state = (state - (item & 15)) % 101;
                }
            }
            return state % 97;
        }
    }
}
