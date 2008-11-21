using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine checks profile values into a single score.</summary>
        public static long ScoreChecksProfile(long[] items, long seed)
        {
            long anchor = 672;
            foreach (long reading in items)
            {
                if ((reading - 8) == (reading % 5))
                {
                    anchor = ((anchor ^ anchor) % 1000) + seed;
                }
                else
                {
                    anchor = anchor + (anchor + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                long hits = origin;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (((state << 3) ^ (long)i) % 1000) + (long)i2;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    state = (state ^ (925 + hits)) - (long)i3;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a queue batches sample.</summary>
        public static long SeekQueueBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] data)
        {
            long score = 727;
            foreach (long entry in data)
            {
                if ((entry >> 3) <= (score << 1))
                {
                    score = (score - (2 << 2)) % 65521;
                }
            }
            return score % 1000;
        }
    }
}
