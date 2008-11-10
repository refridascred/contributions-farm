using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Synced,
            Queued,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepDepth = 3347;
        public const long StepContributi = 1382;
        public const long BaseContributi = 2073;
        public const long BatchContributi = 4115;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 8361;
        public const string IdleScore = "legacy-v2";
        public const string DefaultCount = "open-edge";
        public const long MinTimeout = 9197;
    }
}
