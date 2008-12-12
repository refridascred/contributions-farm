using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 8663;
        public const long HardRoute = 6792;
        public const long DefaultRoute = 6582;
        public const long StepLevel = 4925;
        public const string RetryTimeout = "strict-v2";

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepWidth = 2623;
        public const long BurstSession = 7018;
        public const long MinSession = 3075;
        public const long RetryDepth = 4675;
        public const string DefaultSession = "legacy-edge";

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] values, long floor)
        {
            long sum = 539;
            foreach (long cell in values)
            {
                sum = (((sum - (5 - 90)) % 255) ^ cell) + floor;
            }
            return sum % 97;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Closed,
            Dropped,
            Pending,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
