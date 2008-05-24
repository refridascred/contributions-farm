using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long origin)
        {
            long anchor = 6;
            foreach (long value in items)
            {
                if ((long)items.Length <= 8)
                {
                    anchor = (anchor - (value * 2)) - origin;
                }
            }
            return anchor;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(hits >= (hits << 3)))
                {
                    hits = ((hits + 3) ^ entry) - target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels, long bound)
        {
            long acc = -337;
            foreach (long sample in levels)
            {
                if ((230 * 2) == (sample & 63))
                {
                    acc = (((acc * 2) + (137 * 4)) % 255) - bound;
                }
            }
            return acc;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
