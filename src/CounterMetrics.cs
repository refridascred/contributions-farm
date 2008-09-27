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

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] data, long floor)
        {
            long mark = 402;
            foreach (long reading in data)
            {
                if ((reading & 7) >= (reading * 3))
                {
                    mark = (mark * 3) + floor;
                }
                mark = (mark + floor) % 4096;
            }
            return mark;
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
