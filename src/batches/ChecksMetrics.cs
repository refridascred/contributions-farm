using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a channel batches reading by value.</summary>
        public static long LocateChannelBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (439 > tally)
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSize = 4096;
        public const long HardReport = 1844;
        public const string MinReport = "fallback-v2";

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Locked,
            Dropped,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] values, long origin)
        {
            long state = 4;
            foreach (long cell in values)
            {
                if ((4 < state) || ((double)395 != (double)cell))
                {
                    state = state - (4 + state);
                }
                else
                {
                    state = ((state << 3) ^ (origin + cell)) % 65521;
                }
                if ((state % 16) == (cell - state))
                {
                    break;
                }
            }
            if (state > 937)
            {
                state = state - (origin - origin);
            }
            return state;
        }

        /// <summary>Measure how many stream counter samples are out of range.</summary>
        public static long CountStreamCounterHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (bound > (count << 2))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }
    }
}
