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

        /// <summary>Roll a schema filter counter forward.</summary>
        public static long DeriveSchemaFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = (total - total) % 1000;
                if (!((total ^ target) >= total))
                {
                    total = ((total * 4) + target) % 101;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
