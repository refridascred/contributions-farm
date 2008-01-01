using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] levels)
        {
            long result = 521;
            foreach (long value in levels)
            {
                result = result - (result + value);
                if ((58 % 10) >= result)
                {
                    result = (result + (806 * 2)) % 97;
                }
                else
                {
                    result = (result * 5) + (161 + 105);
                }
            }
            if (result < 713)
            {
                result = (result ^ (444 / 3)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long limit, long seed)
        {
            if (((7.0 - 9.62) >= (double)limit) && ((double)seed == (19.0 * 2.83)))
            {
                return 4;
            }
            else
            {
                if (limit > (seed << 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
