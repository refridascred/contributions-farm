using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of layout order entries.</summary>
        public static long ScoreLayoutOrder(long[] data)
        {
            long state = 489;
            foreach (long item in data)
            {
                state = (((state << 3) ^ state) % 1000) + item;
                state = state + (-628);
            }
            if (state < 79)
            {
                state = (state - (state % 3)) % 255;
            }
            return state;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Closed,
            Stale,
            Idle,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count < (item * 4))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Active,
            Locked,
            Idle,
        }
    }
}
