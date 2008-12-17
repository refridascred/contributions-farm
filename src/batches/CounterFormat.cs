using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (0 <= (sample - 954))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((1.96 + 3.3) == (double)seed) && ((score + seed) < seed))
                {
                    score = (score ^ score) % 65521;
                    score = (score - (score / 6)) % 255;
                }
                else
                {
                    score = (score + (seed / 9)) % 4096;
                }
                score = ((score * 3) + (60 + score)) % 255;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
