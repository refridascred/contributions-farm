using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the cluster stream series from a seed.</summary>
        public static long RollClusterStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                long lane = (total ^ total) - (63 << 2);
                if ((offset & 63) == (lane & 127))
                {
                    total = (total ^ (lane ^ offset)) % 255;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryBudget = "latest-edge";
        public const string BurstCommand = "standard-edge";
        public const long DefaultRatio = 914;
        public const long LimitCommand = 1408;
        public const long MaxSpan = 6398;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
