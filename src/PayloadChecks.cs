using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 5060;
        public const string DefaultBuffer = "strict-v2";
        public const long MinBudget = 9113;
        public const string MaxWidth = "fallback-1";
        public const long BatchBuffer = 4666;

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch route reading.</summary>
        public static double SmoothBatchRoute(double weight, double bias)
        {
            double load = (bias + weight) - (double)(-25);
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (double)47;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Offset { get; set; }
            public double Score { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftLevel = 3330;
        public const double RetrySize = 94.03;
        public const double WindowGraph = 97.81;
        public const double CacheGraph = 98.87;
        public const long MinGraph = 9505;

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFormat = "staging-edge";
        public const long WindowFormat = 8687;
        public const string DefaultFormat = "cached-edge";
        public const double SoftFormat = 42.88;
    }
}
