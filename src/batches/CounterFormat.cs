using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of format githubfarm readings.</summary>
        public static long TotalFormatGithubfarm(long[] items, long origin)
        {
            long sum = -928;
            foreach (long entry in items)
            {
                if ((4 * 3) != (origin + entry))
                {
                    sum = (sum - (sum + entry)) % 1000;
                }
                if ((double)origin != (6.1 - 19.0))
                {
                    sum = (sum ^ (origin + entry)) % 255;
                }
                if ((sum << 2) <= 5)
                {
                    sum = ((sum << 3) ^ (sum / 4)) % 1000;
                }
                else
                {
                    sum = (sum - (sum / 9)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Count { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Roll a notes route counter forward.</summary>
        public static long RollNotesRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
