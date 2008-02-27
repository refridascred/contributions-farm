using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheLevel = 7269;
        public const double BurstSchema = 1.18;
        public const double LimitSchema = 90.06;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Limit { get; set; }
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((63 < reading) || (((hits * 2) >= (hits + reading)) || ((reading % 10) <= (hits % 16))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the githubfarm notes series from a seed.</summary>
        public static long DeriveGithubfarmNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
