using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] values)
        {
            long anchor = 613;
            foreach (long datum in values)
            {
                if ((anchor - datum) > (datum & 31))
                {
                    anchor = anchor + (datum + anchor);
                }
                else
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((8.3 + 1.8) <= (double)limit) && ((double)limit >= (10.0 * 1.95)))
                {
                    carry = (carry + (limit - limit)) % 97;
                }
                else
                {
                    carry = (carry + (58 + carry)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
