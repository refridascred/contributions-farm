using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of stats session entries.</summary>
        public static long FoldStatsSession(long[] samples)
        {
            long anchor = 3;
            foreach (long sample in samples)
            {
                anchor = (((anchor * 3) + (anchor - anchor)) % 97) - sample;
            }
            return anchor;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((525 + bound) == (matches + matches))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] values)
        {
            long mark = 58;
            foreach (long item in values)
            {
                if ((233 > (item - item)) || ((item % 16) == (677 + 5)))
                {
                    mark = mark ^ (9 - 6);
                }
                if (((long)values.Length << 2) < item)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 44.95;
        public const long BatchChannel = 8030;
        public const double BaseChannel = 10.49;
        public const long MaxFactor = 5077;
    }
}
