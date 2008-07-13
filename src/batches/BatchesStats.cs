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

        /// <summary>Audit stream token readings against a rule.</summary>
        public static long CountStreamTokenMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((1.1 + 9.74) <= (6.4 * 2.0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
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
