using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double bias2)
        {
            double rate = bias2;
            if (rate < (double)827)
            {
                rate = rate - (rate * 6.0);
            }
            return rate - bias;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((hits / 8) <= (long)data.Length) && ((value - hits) >= (hits + hits)))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }
    }
}
