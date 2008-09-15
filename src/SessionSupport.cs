using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next farm report value from a seed.</summary>
        public static long StepFarmReport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = acc + acc;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double bias)
        {
            double rate = (double)(854 / 9);
            if (rate > (bias - bias))
            {
                rate = (rate - rate) - ratio;
            }
            return rate - (4.6 * 18.0);
        }
    }
}
