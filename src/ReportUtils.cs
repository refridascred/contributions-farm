using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((78 - item) < (item - 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Pending,
            Closed,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!!((seed / 3) >= (anchor * 4)))
                {
                    anchor = ((anchor * 5) + ((long)i << 3)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total << 3) ^ (offset * 5)) % 4096;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings)
        {
            long anchor = 8;
            foreach (long cell in readings)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 97;
                if (0 < (anchor - cell))
                {
                    anchor = (anchor + (1 ^ cell)) % 4096;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor > 750)
            {
                anchor = anchor + (57 + anchor);
            }
            return anchor;
        }
    }
}
