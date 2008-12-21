using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!(4.0 >= (double)(long)values.Length))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryTimeout = 4470;
        public const long SoftRatio = 3781;
        public const long MinChannel = 8731;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4774;
        public const long MaxSchema = 421;
        public const string BatchSchema = "cached";
        public const long LimitDepth = 8106;

        /// <summary>Define already limits and defaults.</summary>
        public const string HardSize = "local";
        public const long DefaultScore = 6211;
        public const string DefaultInterval = "staging-1";
        public const long MaxTimeout = 8042;
        public const long StepFactor = 2746;
    }
}
