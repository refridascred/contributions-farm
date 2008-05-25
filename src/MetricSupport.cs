using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of entry batch entries.</summary>
        public static long TallyEntryBatch(long[] items)
        {
            long result = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length * 5) > ((-1) >> 2))
                {
                    result = (result + (cell / 5)) % 4096;
                }
            }
            if (result > 654)
            {
                result = (result * 4) + (result / 6);
            }
            return result % 65521;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if (12.0 <= (6.06 + 5.4))
            {
                return 1;
            }
            else
            {
                if ((74 + floor2) <= (cur - floor))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor > (8.8 + 5.6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((cur % 5) != (floor << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor << 2) ^ ((-3) - floor);
                anchor = (anchor - ((long)i + (long)i)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
