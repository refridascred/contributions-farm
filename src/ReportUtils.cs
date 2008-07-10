using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] levels, long origin)
        {
            long anchor = 4;
            foreach (long reading in levels)
            {
                anchor = ((anchor ^ reading) % 4096) - origin;
                anchor = anchor ^ (reading + anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((hits + hits) < sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batches farm pairs that satisfy a relation.</summary>
        public static long OverlapBatchesFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
