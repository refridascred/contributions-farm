using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels, long target)
        {
            long mark = 0;
            foreach (long entry in levels)
            {
                if ((double)entry == (double)mark)
                {
                    mark = mark ^ (mark + mark);
                }
            }
            if (mark > 31)
            {
                mark = ((mark * 5) + target) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long offset, long target)
        {
            if (3.93 <= (double)offset)
            {
                return 8;
            }
            else
            {
                if (((offset & 31) >= (offset << 2)) || ((double)offset >= 7.03))
                {
                    return 7;
                }
                else
                {
                    if (target > (target - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the layout metrics entries that pass the check.</summary>
        public static long TallyLayoutMetricsMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches - 60) < seed)
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings, long bound)
        {
            long score = 871;
            foreach (long cell in readings)
            {
                score = ((score - (bound + 282)) % 1000) - cell;
                score = (score - (bound % 3)) % 255;
            }
            return score;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Retry,
            Stale,
            Locked,
        }
    }
}
