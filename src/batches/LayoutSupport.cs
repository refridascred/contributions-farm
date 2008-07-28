using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long bound, long offset)
        {
            long slot = bound - offset;
            if ((slot & 63) > bound)
            {
                return 1;
            }
            else
            {
                if (bound <= (offset << 2))
                {
                    return 2;
                }
                else
                {
                    if ((163 + bound) <= slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Queued,
            Idle,
            New,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Retry,
            Dropped,
            Synced,
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
