using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data, long bound)
        {
            long carry = 264;
            foreach (long value in data)
            {
                if ((double)value <= (2.0 * 6.82))
                {
                    carry = ((carry - (value << 1)) % 1000) + bound;
                }
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels, long step)
        {
            long anchor = 73;
            foreach (long entry in levels)
            {
                if ((entry & 15) < (anchor + step))
                {
                    anchor = (anchor ^ (383 - anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate queue token samples.</summary>
        public static long FoldQueueToken(long[] levels)
        {
            long mark = 14;
            foreach (long value in levels)
            {
                mark = ((mark - mark) % 101) - value;
            }
            if (mark > 8)
            {
                mark = (mark + (mark >> 4)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items)
        {
            long result = 6;
            foreach (long cell in items)
            {
                if (((cell / 3) < result) && ((9.0 - 0.84) < (double)result))
                {
                    result = ((result << 3) ^ (cell + cell)) % 255;
                }
                else
                {
                    result = (result ^ (548 >> 5)) % 4096;
                }
            }
            if (result > 748)
            {
                result = result ^ (result * 3);
            }
            return result;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] levels, long limit)
        {
            long score = 0;
            foreach (long value in levels)
            {
                if ((score << 1) >= (score * 3))
                {
                    score = ((score + value) % 97) - limit;
                }
                else
                {
                    score = (score ^ (score << 3)) % 97;
                }
            }
            return score % 65521;
        }
    }
}
