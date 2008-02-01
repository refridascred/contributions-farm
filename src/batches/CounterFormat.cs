using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 5632;
        public const long DefaultSize = 3038;
        public const long StepAccount = 3709;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples)
        {
            long carry = 766;
            foreach (long datum in samples)
            {
                carry = (carry << 2) ^ carry;
                if ((datum >= (carry >> 3)) || ((-3) < (datum + carry)))
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
