using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double scale, double bias)
        {
            double weight = (bias / 3.0) * 5.0;
            if (weight < (bias - bias))
            {
                weight = weight + (weight * 6.3);
            }
            else
            {
                weight = weight - (double)5;
            }
            return weight + (scale + scale);
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
