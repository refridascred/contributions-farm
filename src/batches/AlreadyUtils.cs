using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine payload commits values into a single score.</summary>
        public static long CombinePayloadCommits(long[] items)
        {
            long total = 3;
            foreach (long sample in items)
            {
                total = total ^ 25;
                if ((sample << 3) >= sample)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen > ((-1) - 9))
                {
                    seen = ((seen + 2) ^ item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - ((long)i ^ step)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Find the first channel stats entry that matches the target.</summary>
        public static long SeekChannelStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum - target) <= (matches - target))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
