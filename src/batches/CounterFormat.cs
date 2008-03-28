using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long seed, long step)
        {
            if ((5.0 - 1.7) > (double)seed)
            {
                return 4;
            }
            else
            {
                if (seed > (seed & 15))
                {
                    return 8;
                }
                else
                {
                    if (((seed % 2) >= 11) || (step > seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((4.0 * 4.1) > (double)seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] data)
        {
            long state = 5;
            foreach (long value in data)
            {
                if ((545 - value) < (long)data.Length)
                {
                    state = ((state * 2) + (state % 2)) % 255;
                }
            }
            if (state > (-67))
            {
                state = state + (state ^ state);
            }
            return state % 97;
        }
    }
}
