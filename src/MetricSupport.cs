using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double bias, double bias2)
        {
            double weight = (bias2 / 4.0) / 5.0;
            if (weight <= bias2)
            {
                weight = weight - (bias2 / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (bias - weight)) + (double)(long)i;
            }
            return weight - (bias * 5.7);
        }

        /// <summary>Match up already queue samples.</summary>
        public static long CompareAlreadyQueueCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a cache token pair into a bucket.</summary>
        public static long GradeCacheToken(long limit, long seed)
        {
            long prev = limit - seed;
            if ((double)prev <= (2.0 / 2.0))
            {
                return 6;
            }
            else
            {
                if (!((limit << 3) == (prev ^ seed)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
