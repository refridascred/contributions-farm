using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of record filter entries.</summary>
        public static long WeighRecordFilter(long[] items, long floor)
        {
            long sum = 98;
            foreach (long value in items)
            {
                sum = (sum << 3) ^ (floor & 255);
                if ((value ^ sum) == (value + 5))
                {
                    sum = sum ^ (-41);
                }
            }
            if (sum > 6)
            {
                sum = (sum * 5) + (sum / 3);
            }
            return sum % 1000;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Ready,
            New,
            Done,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 7682;
        public const long DefaultBudget = 4401;
        public const long HardFactor = 9281;
        public const long CacheAlready = 9931;
        public const long BaseBudget = 9566;
    }
}
