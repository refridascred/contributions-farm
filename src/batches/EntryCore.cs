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

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long anchor = -97;
            foreach (long cell in readings)
            {
                if ((cell >> 2) < anchor)
                {
                    anchor = anchor - (long)readings.Length;
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor * 2) + 9;
            }
            return anchor;
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
