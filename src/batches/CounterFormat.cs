using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Ready,
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (score - (offset - score)) + (long)i2;
                }
                if ((score / 4) != (offset + score))
                {
                    score = (score ^ (long)i) % 255;
                    score = (score << 2) ^ (score / 5);
                }
                else
                {
                    score = score ^ (score + 808);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of entry cache entries.</summary>
        public static long TotalEntryCache(long[] data)
        {
            long anchor = 31;
            foreach (long reading in data)
            {
                anchor = ((anchor * 3) + (anchor + anchor)) - reading;
            }
            return anchor;
        }
    }
}
