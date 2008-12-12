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

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepWidth = 2623;
        public const long BurstSession = 7018;
        public const long MinSession = 3075;
        public const long RetryDepth = 4675;
        public const string DefaultSession = "legacy-edge";

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] data, long seed)
        {
            long mix = 61;
            foreach (long entry in data)
            {
                if (!((seed + mix) >= (seed & 7)))
                {
                    mix = ((mix << 3) ^ entry) % 65521;
                }
                if ((entry % 16) == (seed + 7))
                {
                    break;
                }
            }
            if (mix < 75)
            {
                mix = ((mix * 2) + (2 >> 2)) % 1000;
            }
            return mix;
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
