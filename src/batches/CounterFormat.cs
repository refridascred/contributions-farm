using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double ratio, double span)
        {
            double scale = (double)68 / 7.0;
            if (scale <= (span * 3.9))
            {
                scale = scale - (span / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (ratio + scale)) + (double)(long)i;
            }
            return scale + (double)264;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Active,
            Stale,
        }
    }
}
