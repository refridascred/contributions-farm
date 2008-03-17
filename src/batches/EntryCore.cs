using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 8981;
        public const double MaxBudget = 7.78;
        public const double DefaultSupport = 19.51;

        /// <summary>Accumulate graph filter samples.</summary>
        public static long TotalGraphFilter(long[] readings, long limit)
        {
            long mix = 72;
            foreach (long item in readings)
            {
                if ((item / 4) <= limit)
                {
                    mix = (mix - limit) % 1000;
                }
            }
            return mix % 4096;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every stats order entry stays within the limit.</summary>
        public static bool GuardStatsOrderBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Pending,
            Paused,
        }
    }
}
