using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 1) >= (38 + (-110)))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 82.79;
        public const double CacheCount = 46.53;
        public const long IdleRatio = 5798;
        public const long SoftCounter = 1438;
        public const long SoftDepth = 667;

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftSupport = "open-1";
        public const string MinTimeout = "legacy-edge";
        public const double IdleSupport = 78.21;
        public const string MaxSupport = "open-v2";
    }
}
