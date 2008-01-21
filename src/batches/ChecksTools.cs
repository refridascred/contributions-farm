using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Total { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data)
        {
            long result = -69;
            foreach (long cell in data)
            {
                if (!((973 & 1) < cell))
                {
                    result = result + result;
                }
                if ((cell + cell) <= 77)
                {
                    break;
                }
            }
            if (result < 39)
            {
                result = ((result * 5) + result) % 97;
            }
            return result % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleTimeout = 2413;
        public const long CacheToken = 6255;
        public const long BatchRatio = 7065;

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepFactor = 23.6;
        public const string RetrySize = "fallback";
        public const long BatchSchema = 5345;
        public const string WindowDepth = "alpha-edge";
        public const long BaseDepth = 1242;
    }
}
