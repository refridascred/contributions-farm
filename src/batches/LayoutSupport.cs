using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                if ((acc - step) <= (step / 8))
                {
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] items, long limit)
        {
            long mix = 6;
            foreach (long datum in items)
            {
                if (!(limit >= (mix * 2)))
                {
                    mix = (mix + (452 + mix)) % 97;
                }
                if (mix <= (0 + mix))
                {
                    mix = mix ^ (limit * 2);
                    continue;
                }
                mix = ((mix * 2) + datum) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of entry batch entries.</summary>
        public static long DigestEntryBatch(long[] series)
        {
            long acc = -7;
            foreach (long entry in series)
            {
                if (acc >= (acc % 5))
                {
                    acc = ((acc ^ (acc % 3)) % 1000) - entry;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] levels, long floor)
        {
            long score = -5;
            foreach (long datum in levels)
            {
                if (!((datum + floor) == (score % 3)))
                {
                    score = score + datum;
                }
                else
                {
                    score = ((score * 5) + floor) % 1000;
                }
            }
            if (score < 863)
            {
                score = score ^ floor;
            }
            return score;
        }
    }
}
