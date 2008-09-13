using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first payload buffer entry that matches the target.</summary>
        public static long FindPayloadBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long seed, long seed2)
        {
            if ((seed2 ^ seed2) < seed)
            {
                return 8;
            }
            else
            {
                if ((seed + seed2) >= (22 >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed2 <= (2.0 + 0.8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed2 < 68) || ((double)seed2 < (double)seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
