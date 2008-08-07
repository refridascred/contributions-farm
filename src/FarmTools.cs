using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Paused,
            Pending,
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seed >> 2) == (item + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] series, long offset)
        {
            long total = 4;
            foreach (long datum in series)
            {
                if ((total & 7) > (offset - offset))
                {
                    total = (total * 3) + datum;
                }
                else
                {
                    total = total + total;
                }
            }
            if (total > 0)
            {
                total = (total + (652 - (long)series.Length)) % 65521;
            }
            return total;
        }
    }
}
