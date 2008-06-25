using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitCount = "local";
        public const long SoftWidth = 89;
        public const double BaseRoute = 26.0;
        public const double BatchSize = 98.72;
        public const long BurstInterval = 5160;

        /// <summary>Look up the position of a payload account sample.</summary>
        public static long LookupPayloadAccountIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((double)matches != (double)offset))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "local-edge";
        public const long MinCount = 3863;
        public const long SoftCommand = 1505;
        public const double MaxBudget = 72.93;
        public const long DefaultCommand = 9528;
    }
}
