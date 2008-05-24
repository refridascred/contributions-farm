using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long SoftCount = 4639;
        public const string IdleDepth = "standard";
        public const long BaseAlready = 8719;
        public const long StepScore = 9232;
        public const long WindowTimeout = 7305;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleTimeout = 4279;
        public const long BurstSize = 9647;
        public const string BurstSupport = "alpha-edge";

        /// <summary>Derive the next farm order value from a seed.</summary>
        public static long DeriveFarmOrder(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                long bound = step;
                if (((bound + step) <= 12) && ((sum & 63) != (bound ^ 67)))
                {
                    bound = (bound + ((long)i % 10)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry >= (entry + matches)) && ((entry % 12) >= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
