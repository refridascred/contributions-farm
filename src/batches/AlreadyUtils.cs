using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(3.07 > (double)origin))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Count the batch stream entries that pass the check.</summary>
        public static long CountBatchStreamGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally >> 5) >= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank batch token input into a small class.</summary>
        public static long BucketBatchToken(long seed, long origin)
        {
            long lane = seed - origin;
            if ((double)origin > 5.83)
            {
                return 5;
            }
            else
            {
                if ((double)origin == (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((origin % 16) != (origin * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin - origin) < lane)
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

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] samples)
        {
            long sum = -72;
            foreach (long entry in samples)
            {
                sum = ((sum << 3) ^ sum) ^ entry;
            }
            return sum % 1000;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Closed,
            Active,
            Retry,
            Pending,
        }
    }
}
