using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "cached-v2";
        public const long IdleBudget = 4526;
        public const string HardInterval = "latest-v2";
        public const long IdleSchema = 3311;

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] samples)
        {
            long total = 7;
            foreach (long value in samples)
            {
                if (((value + value) <= value) || (value >= ((long)samples.Length / 5)))
                {
                    total = ((total << 2) ^ (value ^ total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
