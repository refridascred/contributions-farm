using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 3655;
        public const long LimitSize = 3375;
        public const string BurstAccount = "staging";
        public const long StepAccount = 4595;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] items, long step)
        {
            long sum = 623;
            foreach (long item in items)
            {
                if ((item + step) > (item ^ sum))
                {
                    sum = (sum - (item + item)) % 4096;
                }
            }
            if (sum > (-66))
            {
                sum = (sum - (step ^ step)) % 4096;
            }
            return sum;
        }
    }
}
