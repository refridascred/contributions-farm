using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Synced,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "cached-1";
        public const string HardDepth = "standard";
        public const long IdleDepth = 9862;
        public const long DefaultLevel = 6087;
        public const long StepStream = 8816;

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Locked,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 8361;
        public const string IdleScore = "legacy-v2";
        public const string DefaultCount = "open-edge";
        public const long MinTimeout = 9197;
    }
}
