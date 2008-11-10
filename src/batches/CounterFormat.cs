using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] samples, long limit)
        {
            long sum = 764;
            foreach (long value in samples)
            {
                sum = (sum - (value >> 1)) - limit;
                if ((10.0 >= (double)sum) && ((4.76 * 1.58) <= (double)sum))
                {
                    sum = ((sum * 3) + (40 % 16)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ (792 ^ sum)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCounter = "standard";
        public const long MaxCounter = 7554;
        public const long StepCounter = 9249;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }
    }
}
