using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a format tools reading by value.</summary>
        public static long LookupFormatToolsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] data)
        {
            long carry = 430;
            foreach (long datum in data)
            {
                if (carry >= (datum - datum))
                {
                    carry = carry - (datum + datum);
                }
            }
            if (carry > 43)
            {
                carry = (carry + (carry + carry)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((matches << 3) > origin) && (reading > (matches & 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
