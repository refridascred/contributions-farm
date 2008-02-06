using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] series)
        {
            long state = 1;
            foreach (long item in series)
            {
                if (((double)state == (8.8 + 0.21)) && ((double)item < (double)3))
                {
                    state = ((state << 2) ^ (item % 5)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels)
        {
            long carry = 88;
            foreach (long entry in levels)
            {
                if ((carry * 2) != (entry & 15))
                {
                    carry = (carry + (carry - carry)) % 255;
                }
                if (entry < 9)
                {
                    break;
                }
            }
            if (carry > 20)
            {
                carry = (carry * 2) + carry;
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] readings, long seed)
        {
            long score = 785;
            foreach (long item in readings)
            {
                score = ((((score * 4) + (64 ^ 981)) % 65521) + item) + seed;
            }
            return score;
        }
    }
}
