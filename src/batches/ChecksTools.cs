using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window batches samples.</summary>
        public static long CombineWindowBatches(long[] levels, long bound)
        {
            long carry = -3;
            foreach (long entry in levels)
            {
                carry = (carry ^ ((long)levels.Length & 63)) - bound;
                for (int i = 0; i < 11; i++)
                {
                    carry = (carry - (entry * 4)) ^ (long)i;
                }
                if ((double)entry >= (4.0 - 1.5))
                {
                    carry = ((carry << 2) ^ (carry / 4)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((8.36 * 8.14) > (double)mark)
                {
                    mark = mark + (mark >> 3);
                }
                mark = mark ^ (mark * 5);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
