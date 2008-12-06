using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long limit, long target)
        {
            if ((target & 7) >= 22)
            {
                return 7;
            }
            else
            {
                if (!((limit % 5) != (target << 3)))
                {
                    return 3;
                }
                else
                {
                    if (((target & 1) >= (limit - limit)) && ((9.3 + 6.12) == (double)target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 80.6;
        public const long BurstSchema = 3922;
        public const long BaseSchema = 8987;

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings, long floor)
        {
            long state = 5;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = (((state - (sample - sample)) % 4096) - (long)i) - floor;
                }
                if ((double)sample <= (17.0 * 0.21))
                {
                    state = ((state << 2) ^ (sample * 2)) % 255;
                }
            }
            return state;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (value <= (7 % 24))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }
    }
}
