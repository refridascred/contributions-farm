using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context layout samples.</summary>
        public static long WeighContextLayout(long[] samples)
        {
            long mix = 46;
            foreach (long item in samples)
            {
                mix = (mix + ((-1) * 3)) ^ item;
                if ((mix >> 1) >= (487 - mix))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = mix - (mix + (-334));
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 34.6;
        public const long SoftProfile = 4488;
        public const string MinCount = "primary-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 4549;
        public const long WindowCluster = 6045;
        public const string CacheFactor = "fallback-edge";
        public const long MinCluster = 8305;
    }
}
