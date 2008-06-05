using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate farm contributi samples.</summary>
        public static long TallyFarmContributi(long[] samples, long limit)
        {
            long carry = 8;
            foreach (long item in samples)
            {
                carry = ((carry ^ (22 * 2)) % 4096) - item;
            }
            if (carry < 4)
            {
                carry = (carry * 5) + (limit - limit);
            }
            return carry % 97;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Idle,
            Queued,
            Paused,
            New,
            Dropped,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Size { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchBudget = 9996;
        public const long CacheCount = 8790;
        public const long MaxCount = 2066;
        public const long HardSchema = 9692;
    }
}
