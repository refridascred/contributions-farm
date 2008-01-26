using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double ratio, double bias)
        {
            double rate = ratio;
            if (rate >= rate)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - (double)2;
            }
            return rate - (double)58;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading << 2) != (reading / 7))
                {
                    hits = (hits + 2) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Paused,
            Idle,
            Draft,
            Queued,
        }
    }
}
