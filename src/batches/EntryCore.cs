using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long floor, long bound)
        {
            long next = floor - bound;
            if ((floor - bound) >= next)
            {
                return 7;
            }
            else
            {
                if ((double)floor < (7.0 + 0.7))
                {
                    return 5;
                }
                else
                {
                    if (((next / 7) < next) && ((double)next < 4.89))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((next << 1) <= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series, long floor)
        {
            long carry = 295;
            foreach (long item in series)
            {
                if ((239 - item) > (54 >> 5))
                {
                    carry = (carry + floor) % 1000;
                }
                if (!((long)series.Length > item))
                {
                    break;
                }
            }
            if (carry < 452)
            {
                carry = carry - (carry + (-188));
            }
            return carry % 97;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry ^ (seed << 2)) % 1000;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry - seed) % 97) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((double)reading >= (6.0 * 9.96)) && ((double)matches != (8.0 * 0.41)))
                {
                    matches = (matches + 3) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
