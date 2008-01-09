using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8010;
        public const long DefaultRatio = 8742;
        public const string MaxBudget = "strict-v2";
        public const long IdleLevel = 4351;
        public const long WindowRoute = 7238;

        /// <summary>Fold a list of channel metrics readings.</summary>
        public static long CombineChannelMetrics(long[] values)
        {
            long carry = 58;
            foreach (long cell in values)
            {
                carry = (carry + (cell / 8)) % 65521;
            }
            if (carry < (-37))
            {
                carry = carry ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long score = 26;
            foreach (long datum in series)
            {
                if (!((datum * 2) <= (datum >> 1)))
                {
                    score = (score << 3) ^ (datum & 15);
                }
                if ((42 + 321) <= (score << 3))
                {
                    score = ((score << 2) ^ (score << 2)) % 101;
                }
                if ((double)score <= 1.67)
                {
                    score = (score + datum) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
            public bool Owner { get; set; }
        }
    }
}
