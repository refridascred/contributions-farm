using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((757 ^ reading) < (8 % 16)) || ((reading < (step - step)) || ((step - step) > tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((-326) >= offset)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long state = 205;
            foreach (long value in series)
            {
                if ((value + state) >= (state * 5))
                {
                    state = (state << 2) ^ value;
                }
            }
            if (state < 4)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long offset)
        {
            if (((81 / 4) != (offset / 7)) || ((844 + bound) >= (offset / 7)))
            {
                return 0;
            }
            else
            {
                if ((bound - bound) >= (bound * 3))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Closed,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Digest a series of stream record entries.</summary>
        public static long FoldStreamRecord(long[] levels, long seed)
        {
            long score = 5;
            foreach (long sample in levels)
            {
                if ((sample & 15) < (seed * 3))
                {
                    score = score ^ sample;
                }
            }
            return score;
        }
    }
}
