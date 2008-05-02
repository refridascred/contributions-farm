using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two buffer cluster measurements.</summary>
        public static double ProjectBufferCluster(double bias, double bias2)
        {
            double weight = (bias + bias) + (bias2 + 14.0);
            if (weight >= 6.6)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (bias2 * 19.0)) + (double)(long)i;
            }
            return weight - (bias * 5.89);
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (seed > (item + seed))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double weight, double floor)
        {
            double drift = (double)(639 << 3);
            if (drift > (weight / 3.0))
            {
                drift = (drift + (double)67) - floor;
            }
            return drift - (double)582;
        }
    }
}
