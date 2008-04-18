using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count - count) <= (target % 12))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstSpan = 9597;
        public const long LimitSpan = 2998;
        public const double BaseScore = 61.99;
        public const long DefaultDepth = 2967;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
