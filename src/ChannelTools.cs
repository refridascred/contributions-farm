using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate metrics stream readings against a bound.</summary>
        public static bool CheckMetricsStreamLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + limit) > (231 & 63))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Audit notes farm readings against a rule.</summary>
        public static long MeasureNotesFarmMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (16.0 - 1.0))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }
    }
}
