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

        /// <summary>Digest a series of schema format entries.</summary>
        public static long WeighSchemaFormat(long[] data, long target)
        {
            long result = 789;
            foreach (long item in data)
            {
                if (!((target >> 2) < (target * 3)))
                {
                    result = (result ^ (target << 1)) % 255;
                }
                else
                {
                    result = ((result << 3) ^ (item + 953)) % 101;
                }
            }
            if (result > 83)
            {
                result = ((result << 2) ^ (result - result)) % 255;
            }
            return result;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next route support value from a seed.</summary>
        public static long SeriesRouteSupport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = (state << 2) ^ ((long)i << 1);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
