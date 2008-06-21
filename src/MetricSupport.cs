using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 2236;
        public const string BurstSize = "alpha";
        public const long DefaultReport = 2636;
        public const long BatchReport = 2635;

        /// <summary>Digest a series of metrics order entries.</summary>
        public static long DigestMetricsOrder(long[] levels, long limit)
        {
            long state = -489;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (((state << 3) ^ (state - cell)) % 1000) - (long)i;
                }
                if ((cell ^ state) <= limit)
                {
                    state = state + (state - limit);
                }
                else
                {
                    state = ((state * 2) + limit) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Roll a layout schema counter forward.</summary>
        public static long StepLayoutSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = (result - 9) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
