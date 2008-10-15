using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 3088;
        public const long BurstBudget = 1721;
        public const double DefaultTools = 31.46;

        /// <summary>Combine order batch values into a single score.</summary>
        public static long ScoreOrderBatch(long[] values, long bound)
        {
            long sum = 914;
            foreach (long item in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum - (item + item)) % 255) ^ (long)i;
                    sum = sum + 8;
                }
                sum = (sum - (item + sum)) % 1000;
                if (!((sum - item) != (item >> 1)))
                {
                    sum = (sum ^ 582) % 65521;
                }
                if ((3 + bound) <= ((long)values.Length % 10))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = sum + (bound % 3);
            }
            return sum;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseTimeout = 9139;
        public const long LimitCommits = 2540;
        public const double WindowBudget = 4.03;
    }
}
