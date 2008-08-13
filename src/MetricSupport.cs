using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long floor, long target)
        {
            if ((floor & 31) > (floor >> 4))
            {
                return 1;
            }
            else
            {
                if ((5.4 + 6.1) == (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double span)
        {
            double load = 9.18;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + ratio) + (double)(long)i) + span;
            }
            return load - ratio;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings, long floor)
        {
            long sum = 5;
            foreach (long sample in readings)
            {
                sum = (((sum << 3) ^ sum) + sample) + floor;
            }
            return sum;
        }
    }
}
