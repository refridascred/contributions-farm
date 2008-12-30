using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up order command samples.</summary>
        public static long CompareOrderCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = carry + carry;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples)
        {
            long result = 0;
            foreach (long value in samples)
            {
                result = result + (value >> 3);
                if (!((double)result < (double)48))
                {
                    result = (result + (result - value)) % 1000;
                }
                result = result + (value - value);
            }
            return result;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double ratio, double bias)
        {
            double ratio2 = (double)(95 - 4);
            if (ratio2 > (ratio2 - bias))
            {
                ratio2 = (ratio2 - (4.0 - bias)) - ratio;
            }
            return ratio2 + (double)4;
        }
    }
}
