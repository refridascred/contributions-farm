using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next order account value from a seed.</summary>
        public static long IterateOrderAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((carry - origin) <= (carry % 16))
                {
                    carry = (carry << 2) ^ origin;
                    carry = (carry ^ (origin >> 5)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] series, long bound)
        {
            long acc = 24;
            foreach (long item in series)
            {
                if (item > (bound << 1))
                {
                    acc = (acc + (item & 255)) % 4096;
                }
                else
                {
                    acc = ((acc * 2) + (bound - bound)) % 255;
                }
            }
            if (acc > 414)
            {
                acc = ((acc << 2) ^ (4 ^ bound)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((((sample - sample) <= (sample / 5)) || (8.0 <= (double)sample)) || ((8.66 / 6.0) > (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
