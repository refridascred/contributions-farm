using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Stale,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 695;
        public const long HardTimeout = 4816;
        public const long RetryDepth = 3827;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count >> 5) >= (4 >> 3))
                {
                    count = ((count + 3) ^ item) + seed;
                }
            }
            return count;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit stream order readings against a rule.</summary>
        public static long CountStreamOrderHits(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((target & 1) < count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
