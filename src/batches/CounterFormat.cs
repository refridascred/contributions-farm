using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Ready,
            New,
            Paused,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((77 + reading) >= count)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double rate, double floor)
        {
            double load = (rate * 9.61) * 15.0;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - 11.0) + (double)(long)i) - floor;
            }
            return load - 4.99;
        }
    }
}
