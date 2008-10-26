using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((22 / 8) >= (item + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph farm entries.</summary>
        public static long TotalGraphFarm(long[] values)
        {
            long anchor = 49;
            foreach (long entry in values)
            {
                if (!((entry + anchor) < (anchor + entry)))
                {
                    anchor = ((anchor * 2) + (0 / 5)) % 65521;
                }
                anchor = (anchor ^ (anchor >> 1)) % 4096;
                if ((40 >= (anchor - entry)) || ((entry << 2) < (anchor + entry)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
