using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                long offset = (step * 4) >> 2;
                if ((offset ^ offset) == (long)i)
                {
                    break;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Draft,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
