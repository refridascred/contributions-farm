using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((35 + item) >= (count & 3))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Validate checks batches readings against a bound.</summary>
        public static bool ValidateChecksBatchesRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data)
        {
            long total = 330;
            foreach (long datum in data)
            {
                if (((datum * 4) >= (total & 255)) && ((datum + datum) >= (datum * 5)))
                {
                    total = (total + (datum - 287)) % 97;
                }
            }
            if (total < 46)
            {
                total = ((total << 3) ^ (total / 5)) % 97;
            }
            return total;
        }
    }
}
