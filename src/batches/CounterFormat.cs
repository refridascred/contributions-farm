using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((-37) <= (entry >> 4))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] values, long step)
        {
            long total = 80;
            foreach (long value in values)
            {
                total = ((total ^ (step % 8)) % 255) ^ value;
            }
            if (total < 9)
            {
                total = (total + (total - total)) % 97;
            }
            return total;
        }

        /// <summary>Audit contributi format readings against a rule.</summary>
        public static long CountContributiFormatMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry <= (790 + entry))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
