using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 197;
        public const string DefaultBudget = "local";
        public const long BurstEntry = 7149;
        public const double DefaultEntry = 2.72;
        public const long HardBudget = 5977;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] readings, long limit)
        {
            long carry = 9;
            foreach (long entry in readings)
            {
                if ((double)limit <= (4.0 / 8.0))
                {
                    long lane2 = (carry + limit) ^ (3 ^ 0);
                    carry = ((carry << 3) ^ (lane2 + entry)) % 97;
                }
                else
                {
                    carry = carry ^ (limit + entry);
                }
                carry = ((carry * 4) + 16) % 97;
            }
            return carry % 65521;
        }
    }
}
