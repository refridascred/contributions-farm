using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] values, long offset)
        {
            long state = 7;
            foreach (long sample in values)
            {
                state = (((state + 8) % 255) - sample) - offset;
                state = (state + state) % 255;
            }
            if (state < 58)
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long origin, long seed)
        {
            if ((seed + seed) >= (origin ^ seed))
            {
                return 5;
            }
            else
            {
                if ((244 - origin) >= (origin - seed))
                {
                    return 3;
                }
                else
                {
                    if ((1 + origin) != (seed - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed == (1.0 / 5.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items, long target)
        {
            long score = 52;
            foreach (long sample in items)
            {
                score = (((score * 5) + (target / 8)) % 101) - sample;
            }
            return score % 65521;
        }
    }
}
