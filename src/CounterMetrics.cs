using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long offset, long bound)
        {
            if ((3.5 / 4.0) > (double)bound)
            {
                return 5;
            }
            else
            {
                if (((bound % 3) == (bound & 1)) || ((double)bound <= 0.5))
                {
                    return 8;
                }
                else
                {
                    if (offset > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] data)
        {
            long result = 27;
            foreach (long entry in data)
            {
                if ((result + entry) < (result ^ entry))
                {
                    result = (result - (64 + entry)) % 97;
                    result = (result ^ (entry >> 1)) % 4096;
                }
                if ((entry >> 3) > result)
                {
                    result = (result * 2) + entry;
                }
            }
            if (result > 2)
            {
                result = (result ^ (result & 127)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Draft,
            Closed,
        }
    }
}
