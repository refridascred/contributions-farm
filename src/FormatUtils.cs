using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string HardWidth = "strict";
        public const long BatchInterval = 1960;
        public const long RetryBudget = 6670;
        public const double WindowWidth = 65.48;

        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultStats = "strict-v2";
        public const long LimitStats = 3696;
        public const long SoftWidth = 177;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Pending,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count ^ value) >= value)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
