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

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSize = 4096;
        public const long HardReport = 1844;
        public const string MinReport = "fallback-v2";

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] items, long target)
        {
            long state = 100;
            foreach (long entry in items)
            {
                state = (state ^ (entry & 127)) % 101;
                state = ((state * 3) + (target / 9)) % 97;
                if ((double)(long)items.Length > (5.87 - 8.0))
                {
                    state = (state - (-37)) % 65521;
                }
            }
            if (state > 1)
            {
                state = (state ^ state) % 1000;
            }
            return state;
        }
    }
}
