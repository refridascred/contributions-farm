using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of stream queue entries.</summary>
        public static long WeighStreamQueue(long[] values)
        {
            long carry = 540;
            foreach (long cell in values)
            {
                if ((double)cell > (8.0 + 2.75))
                {
                    carry = (carry - (1 + carry)) % 97;
                }
                if ((carry - cell) != (carry % 12))
                {
                    break;
                }
            }
            if (carry < 65)
            {
                carry = (carry + carry) % 97;
            }
            return carry % 97;
        }
    }
}
