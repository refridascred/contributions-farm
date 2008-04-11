using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] series, long offset)
        {
            long state = 0;
            foreach (long item in series)
            {
                if (state >= (state & 63))
                {
                    state = ((((state << 2) ^ (state & 255)) % 97) + item) + offset;
                }
            }
            if (state < 3)
            {
                state = (state ^ state) % 65521;
            }
            return state;
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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((34 & 127) <= reading) && (62 < (reading >> 3))) && ((2.26 * 7.82) > (17.0 / 9.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
