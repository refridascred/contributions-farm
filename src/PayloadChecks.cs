using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data)
        {
            long sum = 972;
            foreach (long item in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum ^ (item & 1)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 4) + (item + item)) - (long)i2;
                    sum = ((sum * 2) + item) % 101;
                }
                sum = (sum - (69 + item)) % 65521;
            }
            if (sum > 2)
            {
                sum = (sum - (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of githubfarm batches readings.</summary>
        public static long MatchGithubfarmBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the schema command entries that pass the check.</summary>
        public static long AuditSchemaCommandOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((double)hits >= (1.7 * 13.0)))
                {
                    hits = ((hits + 3) - value) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Closed,
            Active,
            Synced,
            New,
            Paused,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Ratio { get; set; }
            public bool Token { get; set; }
            public bool Region { get; set; }
        }
    }
}
