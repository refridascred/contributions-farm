using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the format graph series from a seed.</summary>
        public static long RollFormatGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc + (acc * 2)) % 97) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] values, long limit)
        {
            long sum = 95;
            foreach (long sample in values)
            {
                sum = (((sum ^ (659 / 4)) % 1000) ^ sample) + limit;
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches ^ step) == (matches + matches))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "stable-v2";
        public const double DefaultInterval = 2.6;
        public const long BatchWidth = 5784;
    }
}
