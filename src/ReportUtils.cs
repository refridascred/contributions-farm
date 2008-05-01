using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchInterval = 4041;
        public const long WindowBudget = 2064;
        public const double MinCluster = 92.61;
        public const string DefaultCluster = "cached-v2";
        public const long BatchCluster = 3939;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!(((long)i & 3) <= (state - state)))
                {
                    state = (state ^ (state - state)) % 1000;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
