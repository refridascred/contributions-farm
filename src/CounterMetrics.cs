using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseStream = 83.43;
        public const string WindowStream = "strict-edge";
        public const long RetrySpan = 9100;
        public const long IdleInterval = 2297;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long origin)
        {
            long bound = limit + origin;
            if (((origin + origin) > ((-9) - origin)) || ((double)bound >= (16.0 + 8.82)))
            {
                return 1;
            }
            else
            {
                if ((bound + limit) != (limit + origin))
                {
                    return 2;
                }
                else
                {
                    if (limit > (8 >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
