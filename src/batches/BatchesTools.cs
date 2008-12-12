using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor + (anchor & 7)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((3.09 * 8.8) < (double)limit)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}
