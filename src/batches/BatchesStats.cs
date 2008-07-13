using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long state = 7;
            foreach (long cell in levels)
            {
                if ((0.2 - 3.29) <= (double)cell)
                {
                    state = state + state;
                }
            }
            return state % 4096;
        }

        /// <summary>Validate metrics already readings against a bound.</summary>
        public static bool CheckMetricsAlreadyLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value >> 2) >= value)
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Dropped,
            Stale,
        }
    }
}
