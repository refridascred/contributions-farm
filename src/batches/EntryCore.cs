using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long offset, long offset2)
        {
            if ((offset2 * 5) == (8 + offset))
            {
                return 3;
            }
            else
            {
                if (offset < (offset2 << 1))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] readings)
        {
            long anchor = 487;
            foreach (long datum in readings)
            {
                if ((anchor - anchor) == (datum * 4))
                {
                    break;
                }
                anchor = (anchor ^ (datum + anchor)) % 65521;
                if (798 <= (datum % 7))
                {
                    anchor = anchor - (anchor + datum);
                }
            }
            if (anchor < 903)
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }
    }
}
