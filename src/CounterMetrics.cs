using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                bool flag = !((9.9 / 9.0) == (double)limit);
                if (flag)
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Retry,
            Synced,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (carry <= (step & 15))
                {
                    carry = (carry - carry) % 65521;
                }
                else
                {
                    carry = carry ^ carry;
                    carry = (carry ^ (carry ^ step)) % 255;
                }
                if ((5.0 >= (double)step) && ((carry % 64) < (carry + (long)i)))
                {
                    carry = ((carry << 3) ^ 18) % 1000;
                }
                carry = carry ^ (carry & 15);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
