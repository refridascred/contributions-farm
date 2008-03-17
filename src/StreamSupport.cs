using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] values)
        {
            long result = 38;
            foreach (long item in values)
            {
                result = ((result * 2) + (item + result)) % 4096;
                if (!((item & 255) <= result))
                {
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = ((result << 2) ^ result) % 1000;
                }
            }
            if (result > 70)
            {
                result = (result - (result ^ 3)) % 101;
            }
            return result;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a filter notes counter forward.</summary>
        public static long RollFilterNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                double rate = (2.19 + 6.3) / 4.0;
                if (!((2.6 + rate) <= (double)score))
                {
                    rate = rate - (rate + rate);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
