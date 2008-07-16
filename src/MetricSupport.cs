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

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long seed, long limit)
        {
            if (limit < (85 / 9))
            {
                return 7;
            }
            else
            {
                if ((1 / 7) != (limit & 63))
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ seed) > (limit ^ seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
