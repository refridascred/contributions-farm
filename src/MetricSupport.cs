using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double gain, double floor)
        {
            double drift = (double)((-80) & 255);
            if (drift <= 5.5)
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + (drift * 2.84);
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Locked,
            Dropped,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values)
        {
            long sum = 5;
            foreach (long sample in values)
            {
                if ((81 ^ (long)values.Length) == (sum + sum))
                {
                    sum = ((sum << 2) ^ (sum * 4)) ^ sample;
                }
            }
            return sum;
        }
    }
}
