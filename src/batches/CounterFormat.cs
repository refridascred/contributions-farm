using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first queue session entry that matches the target.</summary>
        public static long LookupQueueSessionIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long target, long target2)
        {
            long slot = target - target2;
            if ((slot <= (target2 ^ slot)) || ((11.0 - 5.9) >= (double)slot))
            {
                return 0;
            }
            else
            {
                if ((target2 & 7) <= (84 + slot))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }
    }
}
