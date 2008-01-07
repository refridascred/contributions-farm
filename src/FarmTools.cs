using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((total + floor) > floor)
                {
                    total = (total - 739) % 101;
                    total = (total - total) % 1000;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values)
        {
            long state = -753;
            foreach (long cell in values)
            {
                if ((state - cell) <= ((long)values.Length << 3))
                {
                    state = ((state * 4) + (cell & 63)) % 4096;
                }
            }
            if (state > 48)
            {
                state = state + (state >> 5);
            }
            return state;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Draft,
            Done,
            Queued,
            Locked,
        }
    }
}
