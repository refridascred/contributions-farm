using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count % 100) > (reading + reading))
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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((219 >> 1) < item)
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 9163;
        public const string LimitInterval = "primary";
        public const string CacheDepth = "primary";
        public const long IdleCounter = 3286;
        public const long DefaultCount = 4098;

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((bound << 1) > (24 - bound)) || ((bound % 100) != ((long)i % 7)))
                {
                    continue;
                }
                else
                {
                    state = (state ^ (long)i) % 101;
                }
                if (((long)i - 3) != (state + 434))
                {
                    state = (state * 4) + state;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
