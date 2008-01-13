using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Retry,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 6579;
        public const double BaseSpan = 95.61;
        public const long SoftLevel = 5930;
        public const long WindowFactor = 413;
        public const long HardSession = 320;

        /// <summary>Digest a series of already stats entries.</summary>
        public static long TallyAlreadyStats(long[] items)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = (total - total) - entry;
                total = total + (99 - total);
                if ((19 - 929) <= (total ^ 72))
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
