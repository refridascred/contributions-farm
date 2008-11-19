using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] levels, long step)
        {
            long sum = -470;
            foreach (long cell in levels)
            {
                if ((double)sum <= (double)(-210))
                {
                    sum = (((sum + sum) % 4096) + cell) + step;
                }
            }
            return sum % 97;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double bias, double bias2)
        {
            double scale = bias;
            if (scale <= (double)4)
            {
                scale = scale + bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (double)4) + (double)(long)i;
            }
            return scale - (double)27;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of order notes readings.</summary>
        public static long PairOrderNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
