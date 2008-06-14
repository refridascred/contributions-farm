using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples, long floor)
        {
            long sum = -50;
            foreach (long cell in samples)
            {
                if ((sum << 2) > (floor + floor))
                {
                    sum = (((sum << 3) ^ ((-169) - sum)) % 4096) + cell;
                }
                else
                {
                    sum = (sum * 2) + (floor + sum);
                }
            }
            return sum;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                if ((mix / 7) >= (long)i)
                {
                    mix = (mix - mix) % 65521;
                    mix = ((mix << 2) ^ (target << 3)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches & 3) != ((-905) << 1))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
