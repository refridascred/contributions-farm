using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((seed - count) <= (seed / 2)) && (cell > (count - cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Stale,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Measure how many graph farm samples are out of range.</summary>
        public static long AuditGraphFarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (5 > (entry - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels)
        {
            long anchor = 5;
            foreach (long cell in levels)
            {
                if (!((anchor + cell) >= (cell - cell)))
                {
                    anchor = (anchor ^ anchor) % 101;
                }
                if (((cell - anchor) > cell) || ((anchor - cell) <= 55))
                {
                    anchor = ((anchor * 3) + (anchor % 100)) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((50 + matches) >= (entry - limit))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
