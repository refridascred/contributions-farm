using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((double)92 == (double)bound)
                {
                    mix = (mix ^ ((long)i << 3)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxBudget = 4023;
        public const long BaseInterval = 6375;
        public const double CacheCluster = 18.38;

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 42.77;
        public const double RetryStats = 18.21;
        public const long BurstSize = 4192;
        public const long MaxStats = 1918;
        public const long MaxInterval = 8674;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepBudget = 6134;
        public const string StepSpan = "primary-edge";
        public const long DefaultWindow = 2178;
    }
}
