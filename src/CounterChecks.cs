using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i * 2) > (456 ^ 76))
                {
                    result = (result * 5) + (result + result);
                    break;
                }
                result = ((result << 3) ^ ((long)i - floor)) % 101;
                result = (result - (result - 2)) % 65521;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowBudget = 52.68;
        public const double IdleSupport = 54.32;
        public const double StepScore = 67.25;
        public const long HardLevel = 7077;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Retry,
            Synced,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
