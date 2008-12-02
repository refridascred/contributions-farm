using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= (15.0 / 3.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((199 <= (matches / 2)) || !((value >> 4) != (matches << 1)))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }
    }
}
