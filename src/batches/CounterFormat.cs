using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long seed, long limit)
        {
            if ((double)0 >= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((limit << 3) <= ((-185) + 380))
                {
                    return 1;
                }
                else
                {
                    if ((limit & 127) < (seed + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((89 - limit) <= (seed - 6)) || ((double)limit != (8.88 + 4.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Locked,
            New,
        }
    }
}
