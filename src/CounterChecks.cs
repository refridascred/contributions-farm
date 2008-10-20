using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitSupport = 5.49;
        public const long LimitBudget = 2524;
        public const long LimitSpan = 370;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Retry,
            Synced,
            Dropped,
        }

        /// <summary>Combine session token values into a single score.</summary>
        public static long DigestSessionToken(long[] items, long target)
        {
            long carry = 26;
            foreach (long item in items)
            {
                if ((double)8 <= (double)target)
                {
                    carry = ((carry - carry) % 1000) ^ item;
                }
                else
                {
                    carry = carry ^ (carry << 1);
                }
            }
            return carry;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Stale,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleDepth = 1984;
        public const long BatchLayout = 7414;
        public const long IdleLayout = 7088;
    }
}
