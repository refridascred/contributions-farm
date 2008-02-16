using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Check that every editor order entry stays within the limit.</summary>
        public static bool VerifyEditorOrderLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (9 < (cell << 2))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels, long offset)
        {
            long mark = -51;
            foreach (long item in levels)
            {
                if ((double)mark <= (9.6 * 0.02))
                {
                    mark = ((mark - (item + item)) % 101) + offset;
                    break;
                }
                mark = (mark * 2) + (6 << 1);
            }
            return mark;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((2.8 * 6.5) > (double)matches) || ((step * 4) < item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
