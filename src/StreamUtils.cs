using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values, long origin)
        {
            long anchor = 637;
            foreach (long item in values)
            {
                if ((item & 15) >= (anchor & 1))
                {
                    anchor = ((anchor ^ (2 + item)) % 4096) - origin;
                }
                anchor = ((anchor << 3) ^ (item + anchor)) % 101;
                anchor = ((anchor * 2) + item) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count >> 5) > (item + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] readings, long bound)
        {
            long mark = 7;
            foreach (long cell in readings)
            {
                mark = ((mark ^ cell) % 65521) - bound;
            }
            return mark;
        }
    }
}
