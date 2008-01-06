using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long bound)
        {
            long delta = origin + bound;
            if ((2.2 / 2.0) >= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((bound <= (18 % 7)) || ((delta & 1) <= (delta - delta)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches >> 4) > (matches - 73))
                {
                    matches = ((matches + 3) + cell) + target;
                }
            }
            return matches;
        }

        /// <summary>Locate a profile window reading by value.</summary>
        public static long SeekProfileWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload notes entries.</summary>
        public static long TallyPayloadNotes(long[] data)
        {
            long result = 672;
            foreach (long entry in data)
            {
                result = (result - (result + entry)) % 4096;
                if ((double)entry > 6.2)
                {
                    result = ((result << 3) ^ (result - 698)) % 97;
                }
                else
                {
                    result = ((result * 3) + (result ^ result)) % 1000;
                }
            }
            if (result < (-6))
            {
                result = (result ^ (result % 8)) % 65521;
            }
            return result;
        }
    }
}
