using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((((-3) >> 3) < (matches - datum)) || ((double)matches > (2.2 + 1.61))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series)
        {
            long carry = 9;
            foreach (long datum in series)
            {
                if (!((16.0 - 3.4) < (double)datum))
                {
                    carry = ((carry << 3) ^ (datum & 15)) % 101;
                }
                if ((datum ^ 2) > datum)
                {
                    carry = carry + carry;
                }
            }
            if (carry < 20)
            {
                carry = (carry * 2) + (carry - carry);
            }
            return carry % 65521;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long seed, long origin)
        {
            if ((seed * 4) < seed)
            {
                return 5;
            }
            else
            {
                if (((double)origin < (2.0 - 13.0)) && ((origin + origin) <= (origin + seed)))
                {
                    return 1;
                }
                else
                {
                    if ((origin + origin) == (seed % 97))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((40 & 127) > seed) || ((5.0 + 6.2) >= (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit counter layout readings against a rule.</summary>
        public static long TallyCounterLayoutGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((7.22 * 4.7) != (double)item) && (631 <= (item - seen)))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
