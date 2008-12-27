using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = (result << 2) ^ seed;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 48.45;
        public const long MinCount = 8525;
        public const long RetryBudget = 3002;
        public const long DefaultContext = 5344;
        public const long DefaultRatio = 7927;
    }
}
