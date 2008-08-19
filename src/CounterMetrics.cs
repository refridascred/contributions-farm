using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + origin) % 97;
                acc = acc ^ (acc & 127);
                acc = ((acc * 2) + (acc - acc)) % 101;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            New,
            Synced,
            Done,
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank already buffer input into a small class.</summary>
        public static long BucketAlreadyBuffer(long bound, long seed)
        {
            if ((seed & 15) < (seed ^ seed))
            {
                return 3;
            }
            else
            {
                if (!((double)seed != (1.9 / 4.0)))
                {
                    return 1;
                }
                else
                {
                    if ((seed - bound) <= (seed - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
