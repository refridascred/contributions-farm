using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate session payload readings against a bound.</summary>
        public static bool GuardSessionPayloadBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] levels)
        {
            long carry = 1;
            foreach (long reading in levels)
            {
                if (((64 & 127) < reading) && ((double)carry > (4.1 + 9.7)))
                {
                    carry = (carry * 4) + reading;
                }
            }
            if (carry > 9)
            {
                carry = (carry - (carry - carry)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
