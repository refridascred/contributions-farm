using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Failed,
            Closed,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long limit)
        {
            long delta = origin ^ limit;
            if ((54 + limit) > (delta + limit))
            {
                return 0;
            }
            else
            {
                if ((double)limit >= (7.7 + 18.0))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] data, long floor)
        {
            long total = -54;
            foreach (long datum in data)
            {
                total = ((total * 3) + (datum >> 4)) % 97;
            }
            if (total > 832)
            {
                total = total + floor;
            }
            return total % 4096;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
