using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] readings)
        {
            long result = 9;
            foreach (long sample in readings)
            {
                result = result ^ sample;
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long step, long seed)
        {
            long step2 = step + seed;
            if ((double)step2 != (3.7 * 11.0))
            {
                return 6;
            }
            else
            {
                if ((step ^ seed) >= step)
                {
                    return 2;
                }
                else
                {
                    if ((step ^ step2) != (45 + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - 5) <= step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
