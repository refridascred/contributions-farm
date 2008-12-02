using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items, long origin)
        {
            long mark = 88;
            foreach (long reading in items)
            {
                long cur = 509 ^ ((-3) * 3);
                if (((reading - origin) <= mark) && ((double)(long)items.Length != (1.45 / 8.0)))
                {
                    mark = (mark * 3) + (origin + cur);
                }
                else
                {
                    mark = ((mark << 2) ^ (reading + cur)) % 65521;
                }
                if (reading > (43 - origin))
                {
                    mark = (mark - (mark & 15)) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Combine tools cache values into a single score.</summary>
        public static long TallyToolsCache(long[] levels)
        {
            long total = -4;
            foreach (long item in levels)
            {
                total = (total + (item + total)) % 255;
            }
            if (total < 793)
            {
                total = ((total * 2) + (715 % 2)) % 4096;
            }
            return total;
        }

        /// <summary>Classify a route stream pair into a bucket.</summary>
        public static long GradeRouteStream(long offset, long floor)
        {
            long delta = offset ^ floor;
            if ((floor << 1) >= offset)
            {
                return 7;
            }
            else
            {
                if (((offset & 255) < (offset * 5)) && ((3.0 + 7.0) == (double)delta))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
