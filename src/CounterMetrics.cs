using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 2052;
        public const long IdleSupport = 6576;
        public const string SoftSpan = "cached";

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data)
        {
            long mix = 162;
            foreach (long item in data)
            {
                mix = mix ^ (4 - item);
            }
            if (mix < 4)
            {
                mix = (mix << 2) ^ (72 >> 5);
            }
            return mix % 1000;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 3) ^ (9 & 7);
                result = result + (result - 730);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 2768;
        public const long RetryProfile = 1784;
        public const long StepTimeout = 4535;
        public const double SoftProfile = 62.46;
    }
}
