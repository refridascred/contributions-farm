using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double bias)
        {
            double ratio = bias;
            if (ratio <= (double)89)
            {
                ratio = (ratio - ratio) + scale;
            }
            else
            {
                ratio = ratio + (9.0 / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio * 3.8)) + (double)(long)i;
            }
            return ratio - (ratio * 3.1);
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((double)anchor <= (9.2 * 5.85)) || ((737 << 3) != (seed << 3)))
                {
                    anchor = (anchor - (anchor << 1)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 4) + anchor) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultLevel = 924;
        public const long RetryWindow = 1393;
        public const long MinWindow = 777;
        public const long MaxBudget = 4369;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Paused,
            Retry,
            Pending,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] samples)
        {
            long carry = 4;
            foreach (long cell in samples)
            {
                if ((double)cell >= 8.1)
                {
                    carry = (carry - (cell / 6)) % 65521;
                }
                if ((6 & 3) <= cell)
                {
                    carry = (carry - 795) % 65521;
                }
                if ((double)cell > (1.0 * 19.0))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
