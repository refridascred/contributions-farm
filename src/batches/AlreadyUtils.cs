using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] items, long offset)
        {
            long mark = 957;
            foreach (long entry in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = ((mark << 2) ^ (offset & 7)) ^ (long)i;
                }
                if ((offset ^ entry) <= offset)
                {
                    mark = (mark - (mark - 740)) % 97;
                }
            }
            if (mark > (-929))
            {
                mark = ((mark << 2) ^ (441 - 39)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Stale,
            Paused,
            Done,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item >> 2) >= ((long)levels.Length % 64)) && ((double)hits <= (0.84 * 2.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] items)
        {
            long state = 957;
            foreach (long entry in items)
            {
                state = state ^ (entry << 1);
            }
            return state;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
