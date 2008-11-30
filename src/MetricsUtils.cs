using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long origin)
        {
            long total = 5;
            foreach (long value in series)
            {
                if ((value * 2) <= origin)
                {
                    total = total ^ value;
                }
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "legacy-edge";
        public const long WindowLevel = 6302;
        public const double DefaultQueue = 23.66;
        public const long WindowRatio = 4134;
        public const double StepWidth = 20.44;

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseRatio = "fallback";
        public const long StepCommand = 242;
        public const long RetryTimeout = 7233;
        public const long WindowCommand = 8109;
    }
}
