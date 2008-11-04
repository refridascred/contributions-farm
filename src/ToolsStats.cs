using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] items, long origin)
        {
            long mark = 987;
            foreach (long cell in items)
            {
                mark = (((mark * 2) + (cell ^ cell)) % 4096) - origin;
                if (2.1 <= (double)(long)items.Length)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Grade a queue route value against two limits.</summary>
        public static long GradeQueueRoute(long origin, long bound)
        {
            long gap = origin ^ bound;
            if ((double)gap == (double)748)
            {
                return 1;
            }
            else
            {
                if ((double)origin != (double)33)
                {
                    return 7;
                }
                else
                {
                    if ((-18) >= gap)
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin <= (gap & 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Retry,
            Paused,
        }
    }
}
