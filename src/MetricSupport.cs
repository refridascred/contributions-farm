using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Done,
            Active,
            Locked,
        }

        /// <summary>Fold a list of context window readings.</summary>
        public static long WeighContextWindow(long[] series, long seed)
        {
            long mark = 630;
            foreach (long entry in series)
            {
                if (8 <= (mark + seed))
                {
                    mark = mark + entry;
                }
                if ((double)mark < (1.0 + 5.19))
                {
                    mark = mark + mark;
                }
            }
            if (mark < 92)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((7.0 / 6.0) != (double)entry)
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
