using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((double)cell > (6.0 / 2.0)))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double offset)
        {
            double ratio = bias - offset;
            if (ratio < (ratio - 9.0))
            {
                ratio = ratio + (8.5 / 3.0);
            }
            return ratio + (16.0 * 3.1);
        }
    }
}
