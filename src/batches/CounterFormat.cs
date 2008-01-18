using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate layout stats readings against a bound.</summary>
        public static bool CheckLayoutStatsLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of account metrics readings.</summary>
        public static long TallyAccountMetrics(long[] levels, long step)
        {
            long carry = 687;
            foreach (long entry in levels)
            {
                carry = ((carry * 4) + (step - 8)) + entry;
            }
            if (carry < 616)
            {
                carry = (carry * 2) + carry;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
