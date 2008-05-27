using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate already graph samples.</summary>
        public static long CombineAlreadyGraph(long[] readings, long target)
        {
            long acc = 993;
            foreach (long cell in readings)
            {
                acc = (((acc * 2) + (8 + acc)) - cell) + target;
            }
            return acc;
        }

        /// <summary>Compare every pair of support token readings.</summary>
        public static long MatchSupportTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((bound + state) < (state / 3))
                {
                    continue;
                }
                else
                {
                    state = (state - (81 + state)) % 101;
                    state = (state ^ bound) % 97;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the already notes entries that pass the check.</summary>
        public static long TallyAlreadyNotesGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!!((entry << 3) < (entry >> 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((0 >> 3) <= count)
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
