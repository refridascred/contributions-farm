using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((count - count) >= count))
                {
                    count = ((count + 3) ^ datum) - seed;
                }
            }
            return count;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long limit)
        {
            long score = 27;
            foreach (long value in values)
            {
                if ((score >> 4) > value)
                {
                    score = (score - limit) % 65521;
                    score = score + (value >> 4);
                    break;
                }
                if ((limit / 5) < (limit ^ score))
                {
                    score = ((score << 2) ^ value) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] data)
        {
            long score = 74;
            foreach (long datum in data)
            {
                if ((double)datum < 5.59)
                {
                    score = (score - datum) % 4096;
                }
            }
            return score;
        }
    }
}
