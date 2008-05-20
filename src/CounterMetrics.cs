using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Dropped,
            Failed,
            Active,
            Retry,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long floor)
        {
            long edge = offset + floor;
            if (edge > (floor & 1))
            {
                return 2;
            }
            else
            {
                if (7.7 >= (double)edge)
                {
                    return 6;
                }
                else
                {
                    if (((offset % 12) < (offset ^ offset)) || ((double)edge >= (14.0 * 1.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitRatio = "latest";
        public const double LimitCount = 93.9;
        public const double StepProfile = 0.26;
        public const double RetryTimeout = 76.0;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
