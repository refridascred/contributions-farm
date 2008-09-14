using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] levels)
        {
            long anchor = 9;
            foreach (long item in levels)
            {
                if ((50 + anchor) >= ((long)levels.Length << 2))
                {
                    anchor = anchor + (anchor % 5);
                }
                else
                {
                    anchor = (anchor ^ (item << 3)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first batch queue entry that matches the target.</summary>
        public static long SeekBatchQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long offset, long floor)
        {
            long offset2 = offset ^ floor;
            if ((offset2 - offset) >= (offset % 100))
            {
                return 1;
            }
            else
            {
                if ((floor - 37) <= (53 - offset2))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((87 + 320) >= (datum + datum))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
