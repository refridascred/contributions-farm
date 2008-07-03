using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long offset)
        {
            if (((offset + bound) > (8 + offset)) && (77 >= bound))
            {
                return 7;
            }
            else
            {
                if (((bound - bound) > offset) || ((offset + offset) < 4))
                {
                    return 4;
                }
                else
                {
                    if ((bound + 477) <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset / 2) > (offset >> 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((seed * 5) > (seed & 31))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
