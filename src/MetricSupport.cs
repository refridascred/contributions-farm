using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = (score + (limit * 5)) % 4096;
                if (((limit ^ (-49)) >= (score + score)) && (score >= ((long)i / 6)))
                {
                    score = (score + ((long)i % 24)) % 4096;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the already notes series from a seed.</summary>
        public static long RollAlreadyNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = (state - (long)i2) % 1000;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
