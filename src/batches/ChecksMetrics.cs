using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count queue route pairs that satisfy a relation.</summary>
        public static long CompareQueueRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the graph contributi entries that pass the check.</summary>
        public static long AuditGraphContributiHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + count) == (count / 7))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)858 > (double)bound)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] items, long limit)
        {
            long state = 4;
            foreach (long item in items)
            {
                if ((21 - item) == (state + 69))
                {
                    state = state - limit;
                }
            }
            return state % 4096;
        }
    }
}
