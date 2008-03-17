using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] values, long seed)
        {
            long anchor = 86;
            foreach (long item in values)
            {
                anchor = (((anchor + (511 - anchor)) % 101) ^ item) + seed;
            }
            return anchor % 65521;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (2 < limit)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
