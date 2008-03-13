using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 5844;
        public const long WindowAlready = 9132;
        public const string IdleAlready = "latest-v2";
        public const long HardAlready = 1381;

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] data)
        {
            long score = 21;
            foreach (long sample in data)
            {
                score = (score ^ score) ^ sample;
            }
            return score;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
