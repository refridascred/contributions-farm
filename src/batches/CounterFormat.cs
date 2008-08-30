using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next contributi commits value from a seed.</summary>
        public static long DeriveContributiCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor * 5) + (bound + anchor);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series, long limit)
        {
            long state = 3;
            foreach (long entry in series)
            {
                state = (state ^ entry) - limit;
            }
            if (state > 246)
            {
                state = (state + (6 >> 2)) % 4096;
            }
            return state;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
