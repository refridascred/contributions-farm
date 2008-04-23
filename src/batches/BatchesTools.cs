using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Paused,
            Queued,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Locate a graph format reading by value.</summary>
        public static long LookupGraphFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
