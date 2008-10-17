using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double rate, double bias)
        {
            double rate2 = (double)(5 >> 4);
            if (rate2 < (bias + rate))
            {
                rate2 = rate2 - 9.0;
            }
            return rate2 + bias;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] samples)
        {
            long anchor = 5;
            foreach (long value in samples)
            {
                if (value < (anchor << 2))
                {
                    anchor = (anchor << 3) ^ (38 - anchor);
                }
            }
            return anchor;
        }
    }
}
