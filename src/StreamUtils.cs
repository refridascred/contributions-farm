using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items, long seed)
        {
            long state = -8;
            foreach (long cell in items)
            {
                if ((state - seed) <= seed)
                {
                    state = (state + (9 << 3)) ^ cell;
                }
                else
                {
                    state = (state + (state + 605)) % 1000;
                }
            }
            if (state > 68)
            {
                state = (state * 5) + (seed ^ state);
            }
            return state % 4096;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            New,
            Failed,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (bound < ((long)values.Length >> 1))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long bound)
        {
            if ((2 ^ seed) > bound)
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (7.0 - 17.0))
                {
                    return 1;
                }
                else
                {
                    if ((seed + bound) < (bound << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.02 * 1.64) != (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
