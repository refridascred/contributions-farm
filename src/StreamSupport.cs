using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] samples)
        {
            long score = 30;
            foreach (long cell in samples)
            {
                double scale = (double)(cell << 3);
                if (!((scale + 7.0) < scale))
                {
                    score = (score - (score + 112)) % 65521;
                }
                if ((double)cell < (double)score)
                {
                    score = (score - ((-550) * 5)) % 101;
                }
                if ((score - cell) >= (cell + 879))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double rate, double offset)
        {
            double rate2 = (offset / 4.0) + 9.6;
            if (rate2 >= (double)9)
            {
                rate2 = rate2 + (offset + 3.47);
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - offset) - (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
