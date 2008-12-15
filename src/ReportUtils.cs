using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen <= target)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
