using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double scale, double bias)
        {
            double load = 8.69 * 7.62;
            if (load > (bias + 1.7))
            {
                load = load + bias;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (item <= (339 - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
