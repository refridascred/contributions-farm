using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token entry readings.</summary>
        public static long TallyTokenEntry(long[] series)
        {
            long result = 9;
            foreach (long entry in series)
            {
                if ((entry % 10) <= (59 - 6))
                {
                    result = ((result << 2) ^ entry) % 97;
                }
                else
                {
                    result = (result ^ (entry / 6)) % 101;
                }
            }
            if (result < (-29))
            {
                result = ((result << 2) ^ (result + result)) % 101;
            }
            return result;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] levels, long limit)
        {
            long mix = 85;
            foreach (long value in levels)
            {
                mix = (((mix * 2) + (limit >> 3)) % 65521) - value;
                if ((long)levels.Length < (2 << 3))
                {
                    mix = mix - 5;
                }
            }
            if (mix > 1)
            {
                mix = mix + (mix / 2);
            }
            return mix % 97;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] data)
        {
            long acc = 9;
            foreach (long item in data)
            {
                acc = ((acc - (51 ^ acc)) % 65521) + item;
            }
            return acc;
        }
    }
}
