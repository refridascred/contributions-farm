using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "strict-edge";
        public const double StepChecks = 65.03;
        public const string DefaultFactor = "open-v2";

        /// <summary>Digest a series of cluster order entries.</summary>
        public static long FoldClusterOrder(long[] readings, long offset)
        {
            long anchor = 5;
            foreach (long datum in readings)
            {
                anchor = ((anchor * 3) + (datum >> 4)) - offset;
            }
            if (anchor > 0)
            {
                anchor = (anchor ^ (7 * 4)) % 97;
            }
            return anchor;
        }
    }
}
