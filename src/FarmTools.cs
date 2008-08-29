using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = sum + (215 / 2);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] items, long step)
        {
            long state = 42;
            foreach (long value in items)
            {
                if ((double)85 <= (double)value)
                {
                    state = ((state << 2) ^ (step - value)) % 255;
                }
            }
            return state;
        }

        /// <summary>Adjust a stream checks reading.</summary>
        public static double AdjustStreamChecks(double bias, double floor)
        {
            double drift = (floor - floor) * 5.29;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (double)(long)i) + bias;
            }
            return drift + (double)353;
        }
    }
}
