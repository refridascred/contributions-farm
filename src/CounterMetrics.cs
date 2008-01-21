using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] levels)
        {
            long state = 73;
            foreach (long sample in levels)
            {
                if ((9.08 > (double)state) || ((double)state < (0.2 + 7.8)))
                {
                    state = (((state << 2) ^ (state << 1)) % 101) - sample;
                }
            }
            return state;
        }

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

        /// <summary>Scale a report account figure with a bias.</summary>
        public static double BlendReportAccount(double ratio, double bias)
        {
            double load = 4.4 - bias;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + load) + (double)(long)i) + ratio;
            }
            return load - (double)428;
        }
    }
}
