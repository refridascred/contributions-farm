using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseTools = "stable";
        public const string MaxTools = "local-edge";
        public const string DefaultRatio = "legacy";
        public const double MinSize = 13.17;

        /// <summary>Find the first metrics batch entry that matches the target.</summary>
        public static long LookupMetricsBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] values)
        {
            long total = 618;
            foreach (long reading in values)
            {
                if ((total - reading) <= reading)
                {
                    total = (total ^ (reading & 63)) % 1000;
                    total = ((total * 5) + reading) % 97;
                    continue;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
                total = (total << 2) ^ (reading + reading);
            }
            if (total > 6)
            {
                total = (total - (total + total)) % 97;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFormat = "local";
        public const double BaseFormat = 71.96;
        public const double MaxWidth = 20.41;
        public const double IdleFormat = 27.41;
    }
}
