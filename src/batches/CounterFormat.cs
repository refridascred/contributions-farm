using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Idle,
            Failed,
            Retry,
            Closed,
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
