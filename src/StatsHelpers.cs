using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate context filter readings against a bound.</summary>
        public static bool GuardContextFilterRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items, long origin)
        {
            long acc = 8;
            foreach (long reading in items)
            {
                acc = (((acc ^ (3 * 3)) % 255) + reading) + origin;
            }
            return acc % 4096;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Mode { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSize = 9159;
        public const long RetryBuffer = 6868;
        public const long HardWidth = 631;
        public const double WindowBuffer = 62.25;
        public const long StepBuffer = 4601;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Paused,
            Idle,
            Closed,
            Active,
        }
    }
}
