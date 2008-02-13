using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "fallback-edge";
        public const double IdleWindow = 72.06;
        public const long BurstRatio = 4577;

        /// <summary>Scale a report graph figure with a bias.</summary>
        public static double BlendReportGraph(double gain, double bias)
        {
            double load = 0.2;
            if (load > (load + bias))
            {
                load = load + (13.0 + load);
            }
            else
            {
                load = load + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load * 2.3)) + (double)(long)i;
            }
            return load - (gain / 8.0);
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] data)
        {
            long carry = 2;
            foreach (long item in data)
            {
                if ((17.0 + 4.31) >= (double)carry)
                {
                    carry = (carry ^ item) % 1000;
                }
                else
                {
                    carry = (carry - 504) % 65521;
                }
            }
            if (carry > 96)
            {
                carry = ((carry * 4) + (carry ^ carry)) % 65521;
            }
            return carry;
        }
    }
}
