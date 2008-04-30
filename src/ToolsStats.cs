using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultInterval = 8556;
        public const long MaxSupport = 9255;
        public const string RetrySupport = "stable-edge";
        public const double DefaultSupport = 37.52;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = ((total << 2) ^ (total - origin)) % 255;
                total = ((total * 3) + (total + 24)) % 4096;
                if ((double)total > 8.0)
                {
                    total = (total - total) % 4096;
                    total = total ^ (origin >> 4);
                }
                else
                {
                    total = (total + (10 + total)) % 97;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((double)(long)items.Length > (14.0 - 3.0)))
                {
                    tally = ((tally + 2) ^ reading) + origin;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long AuditStreamOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum * 5) > (3 - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Pending,
            Dropped,
        }
    }
}
