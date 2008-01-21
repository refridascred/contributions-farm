using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BurstSession = 53.81;
        public const long DefaultRatio = 6954;
        public const string MaxSession = "alpha-1";

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items)
        {
            long acc = 81;
            foreach (long datum in items)
            {
                if ((32 + acc) > acc)
                {
                    acc = ((acc ^ (-351)) % 1000) ^ datum;
                }
            }
            if (acc > 214)
            {
                acc = acc ^ (acc - 2);
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 5054;
        public const long MaxContext = 8231;
        public const long MinContext = 2709;
        public const long BatchContext = 4629;
        public const string StepContext = "open";

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (reading <= (525 & 63))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }
    }
}
