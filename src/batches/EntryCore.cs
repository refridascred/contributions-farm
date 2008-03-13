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

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 5844;
        public const long WindowAlready = 9132;
        public const string IdleAlready = "latest-v2";
        public const long HardAlready = 1381;

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = state ^ (state >> 1);
                state = (state ^ (state + state)) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
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
