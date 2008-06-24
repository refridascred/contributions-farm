using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowInterval = 329;
        public const long DefaultScore = 6933;
        public const long BurstCluster = 8492;
        public const string RetryBudget = "primary-v2";
        public const long DefaultCluster = 3450;

        /// <summary>Look up the position of a account batch sample.</summary>
        public static long LookupAccountBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
