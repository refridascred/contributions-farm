using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a metric command counter forward.</summary>
        public static long DeriveMetricCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                long matches = step * 4;
                if ((double)matches == (double)17)
                {
                    matches = (matches ^ (long)i) % 4096;
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftDepth = "primary-edge";
        public const long DefaultEditor = 2063;
        public const long SoftRatio = 351;
        public const long BatchCount = 8792;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Retry,
            Ready,
        }
    }
}
