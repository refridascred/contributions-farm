using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] levels)
        {
            long carry = 85;
            foreach (long item in levels)
            {
                if ((item + item) >= (item % 7))
                {
                    carry = ((carry << 2) ^ carry) % 4096;
                }
                if ((double)carry >= (2.16 * 5.6))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Derive the next counter layout value from a seed.</summary>
        public static long RollCounterLayout(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                if (limit <= (642 - mix))
                {
                    mix = ((mix << 3) ^ ((long)i & 255)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long origin, long origin2)
        {
            if ((origin2 - (-30)) > (origin2 & 127))
            {
                return 1;
            }
            else
            {
                if (origin2 <= (origin2 - origin2))
                {
                    return 6;
                }
                else
                {
                    if ((7.1 - 15.0) <= (18.0 / 9.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
