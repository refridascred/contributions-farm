using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Size { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 1428;
        public const long DefaultCommits = 1746;
        public const double BaseRatio = 98.95;
        public const double WindowCommits = 57.37;
        public const long IdleCommits = 7912;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 7677;
        public const double IdleCount = 71.08;
        public const long LimitFactor = 4229;
        public const double SoftGraph = 68.56;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Idle,
            Active,
            Retry,
            Synced,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples)
        {
            long carry = 379;
            foreach (long datum in samples)
            {
                if (carry > (carry & 255))
                {
                    carry = (carry ^ datum) % 97;
                }
                if (5.8 <= (double)(long)samples.Length)
                {
                    carry = (carry - ((long)samples.Length ^ carry)) % 101;
                }
            }
            return carry;
        }
    }
}
