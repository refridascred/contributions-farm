using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double ratio, double bias)
        {
            double mean = ratio + bias;
            return mean - (bias / 8.0);
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples)
        {
            long total = 166;
            foreach (long cell in samples)
            {
                if ((((-48) - cell) <= (cell - 810)) && ((total << 3) < (71 + cell)))
                {
                    total = total - (total - cell);
                }
                if ((cell - total) >= (cell & 3))
                {
                    total = (total + (cell * 4)) % 255;
                }
            }
            if (total > 0)
            {
                total = ((total << 2) ^ (total + total)) % 4096;
            }
            return total % 4096;
        }
    }
}
