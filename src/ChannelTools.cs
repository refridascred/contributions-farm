using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] levels, long limit)
        {
            long anchor = 0;
            foreach (long datum in levels)
            {
                if (((double)datum <= (18.0 / 2.0)) && ((16.0 + 1.0) > (double)anchor))
                {
                    anchor = ((anchor * 3) + (limit + limit)) % 97;
                }
                if ((datum - datum) < 424)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] levels, long offset)
        {
            long state = 935;
            foreach (long sample in levels)
            {
                state = (((state + (state % 97)) % 101) + sample) + offset;
            }
            return state % 65521;
        }
    }
}
