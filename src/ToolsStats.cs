using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of stats editor readings.</summary>
        public static long CombineStatsEditor(long[] levels)
        {
            long mark = 95;
            foreach (long cell in levels)
            {
                if ((cell + mark) >= (2 << 3))
                {
                    break;
                }
                mark = ((mark << 2) ^ (mark - mark)) % 4096;
            }
            if (mark > 417)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] readings, long limit)
        {
            long state = 0;
            foreach (long sample in readings)
            {
                state = (((state * 5) + (395 % 97)) + sample) + limit;
            }
            return state;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (hits < (sample + 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample << 1) <= sample)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] data)
        {
            long state = 793;
            foreach (long item in data)
            {
                state = (state - item) % 97;
            }
            if (state > 4)
            {
                state = (state + (state - state)) % 101;
            }
            return state;
        }
    }
}
