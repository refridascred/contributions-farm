using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] data, long origin)
        {
            long sum = 417;
            foreach (long datum in data)
            {
                sum = ((sum + (sum - (long)data.Length)) ^ datum) - origin;
            }
            return sum;
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
