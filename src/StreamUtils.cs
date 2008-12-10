using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count <= (datum + datum))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (582 >= (value - matches))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Locked,
            Dropped,
            Idle,
            Pending,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally & 7) <= tally)
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long offset, long target)
        {
            long lane = offset - target;
            if (((lane - offset) <= (211 - target)) || ((7.5 * 5.18) >= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((1.0 + 6.1) > (double)lane)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
