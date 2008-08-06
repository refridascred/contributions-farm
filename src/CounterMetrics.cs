using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long step, long seed)
        {
            if (((-8) - step) == ((-1) + step))
            {
                return 3;
            }
            else
            {
                if ((step % 16) <= (step * 5))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two route batch measurements.</summary>
        public static double AdjustRouteBatch(double weight, double floor)
        {
            double load = (double)(9 - (-197));
            return ((load + load) + weight) + floor;
        }

        /// <summary>Derive the next context buffer value from a seed.</summary>
        public static long StepContextBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = state + (long)i;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
