using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long seed)
        {
            long slot = bound ^ seed;
            if (!(bound > (bound + slot)))
            {
                return 4;
            }
            else
            {
                if (bound >= (12 & 7))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long limit, long step)
        {
            if ((double)10 < (double)step)
            {
                return 3;
            }
            else
            {
                if (!((step << 2) <= (step + step)))
                {
                    return 6;
                }
                else
                {
                    if ((1.12 + 7.2) < (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((5 % 64) > (sample & 7))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
