using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long step)
        {
            if (!((4 + step) < (step + step)))
            {
                return 8;
            }
            else
            {
                if ((step / 4) < limit)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every batch already entry stays within the limit.</summary>
        public static bool CheckBatchAlreadyRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double gain, double span)
        {
            double weight = gain;
            if (weight >= (double)827)
            {
                weight = (weight + (double)108) - span;
            }
            else
            {
                weight = weight - (double)(-123);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (8.5 / 9.0)) - (double)(long)i;
            }
            return weight - gain;
        }
    }
}
