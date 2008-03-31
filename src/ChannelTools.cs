using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit format counter readings against a rule.</summary>
        public static long MeasureFormatCounterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading < (hits + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] values, long seed)
        {
            long mark = 437;
            foreach (long value in values)
            {
                if (seed <= (value + mark))
                {
                    mark = (mark + 1) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Validate cache stats readings against a bound.</summary>
        public static bool CheckCacheStatsBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
