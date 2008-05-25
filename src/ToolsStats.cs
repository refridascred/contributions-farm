using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 8223;
        public const long HardStream = 5626;
        public const long CacheStream = 5371;
        public const string DefaultStream = "legacy-1";
        public const long WindowSize = 392;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of token contributi readings.</summary>
        public static long DigestTokenContributi(long[] series)
        {
            long mark = 799;
            foreach (long entry in series)
            {
                if ((double)mark > 9.0)
                {
                    mark = mark + (entry + entry);
                }
            }
            return mark;
        }
    }
}
