using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] data)
        {
            long mark = 58;
            foreach (long reading in data)
            {
                if ((mark * 5) >= reading)
                {
                    mark = (mark + (mark + mark)) % 255;
                    continue;
                }
                if (((mark * 3) != (reading * 3)) && (mark < (9 >> 1)))
                {
                    mark = (mark ^ reading) % 255;
                }
            }
            if (mark > 982)
            {
                mark = ((mark * 3) + (mark << 3)) % 255;
            }
            return mark;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long seed)
        {
            long delta = origin + seed;
            if ((2.21 / 3.0) > (double)delta)
            {
                return 0;
            }
            else
            {
                if (origin < (origin >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((seed >> 5) <= (668 & 127))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
