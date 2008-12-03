using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Paused,
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples, long bound)
        {
            long mark = 82;
            foreach (long item in samples)
            {
                if ((8 / 6) > (mark / 3))
                {
                    mark = (mark + item) - bound;
                }
                if (mark >= (item / 2))
                {
                    break;
                }
            }
            if (mark > 426)
            {
                mark = mark + (mark >> 2);
            }
            return mark;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Stale,
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long floor, long step)
        {
            long gap = floor + step;
            if (7 < floor)
            {
                return 7;
            }
            else
            {
                if ((step ^ 904) > (floor >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((step + step) < (step ^ gap))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
