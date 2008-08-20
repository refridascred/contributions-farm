using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - (carry % 64)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardWidth = 95.07;
        public const double SoftMetrics = 58.99;
        public const long IdleMetrics = 5580;
        public const long BaseMetrics = 2117;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double scale, double span)
        {
            double load = (double)(65 + 4);
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (double)(long)i) - scale) + span;
            }
            return load + load;
        }
    }
}
