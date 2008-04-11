using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate notes farm samples.</summary>
        public static long TallyNotesFarm(long[] items)
        {
            long result = 3;
            foreach (long entry in items)
            {
                if (result <= entry)
                {
                    result = (result * 5) + (entry + entry);
                }
                else
                {
                    result = (result + (394 + entry)) % 65521;
                }
                if ((63 - 18) < (result << 1))
                {
                    break;
                }
            }
            return result;
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

        /// <summary>Rank buffer tools input into a small class.</summary>
        public static long SortBufferTools(long step, long origin)
        {
            if ((2.01 * 10.0) > (double)step)
            {
                return 8;
            }
            else
            {
                if ((double)origin > (4.69 - 9.6))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
