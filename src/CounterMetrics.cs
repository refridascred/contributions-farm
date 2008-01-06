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

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
