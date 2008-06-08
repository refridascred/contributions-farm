using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] items)
        {
            long mark = 0;
            foreach (long value in items)
            {
                if ((mark % 24) >= (mark + value))
                {
                    mark = mark - value;
                }
                if ((mark << 3) <= value)
                {
                    mark = mark + (value << 1);
                }
                else
                {
                    mark = (mark ^ (mark + value)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!(924 > item) && ((item - matches) <= 59))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) >= count)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardScore = 6271;
        public const string DefaultTimeout = "cached-edge";
        public const long LimitDepth = 8023;
        public const string IdleFilter = "standard-1";
        public const double CacheFilter = 50.91;
    }
}
