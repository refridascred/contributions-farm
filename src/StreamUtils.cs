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

        /// <summary>Compare every pair of command context readings.</summary>
        public static long PairCommandContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
