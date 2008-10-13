using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double weight, double floor)
        {
            double gain = (weight + 3.1) - (double)995;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)(long)i) - floor;
            }
            return gain + (gain / 3.0);
        }

        /// <summary>Grade a support payload value against two limits.</summary>
        public static long BucketSupportPayload(long step, long step2)
        {
            long diff = step ^ step2;
            if ((323 << 1) < (diff + diff))
            {
                return 5;
            }
            else
            {
                if ((step2 & 63) > step2)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 4569;
        public const string HardLevel = "latest-edge";
        public const long MinCluster = 3840;
        public const long StepCluster = 9456;
    }
}
