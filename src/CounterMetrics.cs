using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a window format counter forward.</summary>
        public static long DeriveWindowFormat(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum ^ (sum % 16)) % 97;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum - (bound - (long)i)) % 4096) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 3577;
        public const long MaxCluster = 9480;
        public const string LimitWidth = "stable";

        /// <summary>Locate a metric counter reading by value.</summary>
        public static long LocateMetricCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "stable-edge";
        public const long SoftSize = 543;
        public const double SoftStream = 97.82;
        public const long StepStream = 6559;
    }
}
