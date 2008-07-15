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

        /// <summary>Derive the next metrics counter value from a seed.</summary>
        public static long DeriveMetricsCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((anchor - offset) > 846)
                {
                    anchor = ((anchor << 2) ^ (anchor * 4)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
