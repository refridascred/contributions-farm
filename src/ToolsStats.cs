using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Ready,
            Stale,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long origin)
        {
            long cur = floor + origin;
            if ((floor / 9) > (floor << 2))
            {
                return 3;
            }
            else
            {
                if (!(cur < ((-449) - floor)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}
