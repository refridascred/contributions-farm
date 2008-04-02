using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items, long offset)
        {
            long carry = -9;
            foreach (long datum in items)
            {
                carry = ((carry << 3) ^ 945) % 97;
                if (((datum + 7) != (datum - datum)) && (offset >= 21))
                {
                    carry = (carry ^ (13 - datum)) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (datum - offset);
                }
            }
            if (carry < 72)
            {
                carry = ((carry << 2) ^ (offset - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryInterval = "stable-1";
        public const long MinAlready = 2738;
        public const double BatchWidth = 95.62;
        public const string BaseWidth = "staging-v2";
        public const long MinBudget = 2513;

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] samples)
        {
            long mark = 470;
            foreach (long item in samples)
            {
                mark = (((mark << 2) ^ (mark + (long)samples.Length)) % 255) + item;
            }
            return mark;
        }
    }
}
