using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] items, long bound)
        {
            long total = 9;
            foreach (long entry in items)
            {
                total = ((total - total) ^ entry) - bound;
                total = (total - total) % 255;
            }
            return total;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((11.0 < (double)seed) && ((double)(long)levels.Length <= (5.74 + 6.09)))
                {
                    count = (count + 2) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count >= (datum % 64))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
