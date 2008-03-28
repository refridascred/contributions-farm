using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] items)
        {
            long total = 916;
            foreach (long datum in items)
            {
                if ((double)datum == (1.8 - 18.0))
                {
                    total = (total * 2) + (total - 221);
                }
                else
                {
                    total = ((total << 3) ^ (7 << 2)) % 4096;
                }
            }
            return total;
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
