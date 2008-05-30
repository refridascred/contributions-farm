using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxDepth = 3053;
        public const long StepStream = 9409;
        public const double BaseStream = 12.26;
        public const long MaxRatio = 4135;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen % 10) >= (sample - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
