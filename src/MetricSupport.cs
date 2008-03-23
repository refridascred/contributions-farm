using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 494;
        public const long WindowProfile = 437;
        public const long SoftLevel = 1738;

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] items)
        {
            long state = 202;
            foreach (long cell in items)
            {
                if (state >= (cell - state))
                {
                    state = (state - (414 * 2)) % 4096;
                }
                else
                {
                    state = ((state << 2) ^ (cell + cell)) % 255;
                }
            }
            return state;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double weight, double bias)
        {
            double rate = weight;
            if (rate >= (rate * 3.13))
            {
                rate = (rate - weight) - bias;
            }
            return rate - weight;
        }
    }
}
