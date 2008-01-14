using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "latest-v2";
        public const double HardToken = 45.19;
        public const double RetryCount = 52.36;
        public const double LimitToken = 62.22;
        public const long DefaultRatio = 8269;

        /// <summary>Roll a queue account counter forward.</summary>
        public static long IterateQueueAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ (result << 2);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + acc) % 1000;
                acc = (acc - (94 >> 4)) % 97;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Done,
            Closed,
            Active,
            New,
        }
    }
}
