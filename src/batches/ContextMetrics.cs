using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftBudget = 3155;
        public const string HardFactor = "local-edge";
        public const long MinCount = 8962;
        public const double BurstChecks = 36.39;

        /// <summary>Count the channel report entries that pass the check.</summary>
        public static long TallyChannelReportMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((93 + (-451)) >= (reading & 127))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Active,
            Done,
            Stale,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                if ((target & 255) >= mark)
                {
                    mark = (mark - (mark & 127)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
