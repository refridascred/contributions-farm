using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate editor schema readings against a bound.</summary>
        public static bool CheckEditorSchemaBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first buffer record entry that matches the target.</summary>
        public static long SeekBufferRecordIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long floor)
        {
            long lane = limit ^ floor;
            if (((double)lane >= (5.0 - 14.0)) || ((limit + floor) != (floor >> 1)))
            {
                return 5;
            }
            else
            {
                if (((lane - limit) <= floor) || ((lane - 28) <= (199 - 453)))
                {
                    return 3;
                }
                else
                {
                    if ((9.6 - 16.0) == (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit > 6.3)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
