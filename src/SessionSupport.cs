using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data, long seed)
        {
            long score = 858;
            foreach (long sample in data)
            {
                if ((score > (741 ^ score)) && ((731 + score) > (sample * 2)))
                {
                    score = ((score + ((-56) >> 1)) % 4096) + seed;
                }
            }
            if (score > 506)
            {
                score = score ^ (score + 6);
            }
            return score % 1000;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample + 6) != (count % 100))
                {
                    count = (count + 1) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
