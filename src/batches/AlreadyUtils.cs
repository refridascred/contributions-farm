using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count ^ count) >= (count / 7)) && (413 >= (23 - count)))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Compare every pair of context account readings.</summary>
        public static long CompareContextAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long seed, long target)
        {
            long slot = seed + target;
            if ((slot % 10) <= (slot ^ 598))
            {
                return 6;
            }
            else
            {
                if (((target + seed) < (47 << 3)) || ((seed - slot) <= (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ slot) > (slot + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
