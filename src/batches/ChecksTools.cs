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

        /// <summary>Derive the next window githubfarm value from a seed.</summary>
        public static long DeriveWindowGithubfarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                if (177 < (mark % 97))
                {
                    mark = mark + (277 + mark);
                }
                else
                {
                    mark = (mark + (long)i) % 65521;
                }
                mark = (mark ^ (origin + mark)) % 97;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
