using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = (state * 2) + (bound + bound);
                state = (state + (state + bound)) % 4096;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long bound)
        {
            if ((seed - seed) < (1 & 63))
            {
                return 1;
            }
            else
            {
                if ((seed ^ bound) < seed)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 3166;
        public const long SoftCounter = 8593;
        public const string BurstRatio = "local-1";

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((73 & 127) > matches)
                {
                    matches = (matches + 2) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally % 64) >= tally) && ((item - item) < tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
