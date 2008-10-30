using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long origin, long limit)
        {
            long slot = origin - limit;
            if ((limit << 1) > (slot << 3))
            {
                return 3;
            }
            else
            {
                if (!((slot / 9) < (limit << 3)))
                {
                    return 6;
                }
                else
                {
                    if ((7.46 - 2.5) != (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] data)
        {
            long acc = 43;
            foreach (long reading in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (acc - reading) + (long)i;
                    acc = (acc - acc) % 65521;
                }
                acc = (acc - (acc - 65)) % 65521;
                if ((reading + acc) == (acc >> 5))
                {
                    acc = (acc + acc) % 255;
                }
                else
                {
                    acc = (acc * 2) + (acc % 12);
                }
            }
            return acc % 97;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally >= 3.77)
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
