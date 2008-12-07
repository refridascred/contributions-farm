using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Active,
            New,
            Paused,
            Queued,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double gain, double bias)
        {
            double scale = bias;
            if (scale < bias)
            {
                scale = scale + (double)4;
            }
            else
            {
                scale = scale + (gain - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + (double)115;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double ratio, double floor)
        {
            double gain = ratio - floor;
            if (gain <= (double)7)
            {
                gain = gain + 3.51;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 20.0) + (double)(long)i;
            }
            return gain - 2.74;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long floor)
        {
            if (((floor - limit) == (limit / 5)) && ((5.0 + 4.8) == (double)limit))
            {
                return 8;
            }
            else
            {
                if (!((limit & 31) > (limit * 5)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
