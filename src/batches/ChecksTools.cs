using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Total { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first queue account entry that matches the target.</summary>
        public static long LookupQueueAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleTimeout = 2413;
        public const long CacheToken = 6255;
        public const long BatchRatio = 7065;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Weight { get; set; }
            public double Score { get; set; }
        }
    }
}
