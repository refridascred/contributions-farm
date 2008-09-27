using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((seed << 2) <= (matches + (-9)))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Active,
            New,
            Paused,
            Closed,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((1.0 + 9.01) <= (double)reading) && ((469 / 8) >= reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
