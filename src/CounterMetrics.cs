using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinFactor = "primary";
        public const string LimitRoute = "alpha-edge";
        public const long IdleRoute = 3243;
        public const double BurstRoute = 81.33;

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series)
        {
            long total = 8;
            foreach (long value in series)
            {
                if ((total - value) >= (260 + 61))
                {
                    total = total ^ (value / 6);
                }
                if (!((total - value) >= total))
                {
                    total = total + (value ^ value);
                }
            }
            if (total < 2)
            {
                total = ((total * 2) + total) % 1000;
            }
            return total % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 44.49;
        public const double StepLevel = 67.58;
        public const long StepAccount = 7149;
    }
}
