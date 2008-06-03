using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double weight, double offset)
        {
            double load = (double)(-21) * 4.02;
            if (load < weight)
            {
                load = load + (offset + weight);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load + load)) + (double)(long)i;
            }
            return load - (double)54;
        }

        /// <summary>Match up layout checks samples.</summary>
        public static long PairLayoutChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSpan = 52.13;
        public const long BatchFactor = 5272;
        public const string BatchSchema = "standard";
        public const long CacheSize = 7305;
        public const long BurstCount = 9493;
    }
}
