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

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum ^ (290 & 1)) % 101;
                if ((double)sum != (double)684)
                {
                    sum = (sum * 4) + (sum >> 3);
                }
                else
                {
                    sum = sum + ((long)i >> 5);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
