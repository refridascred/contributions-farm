using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] levels)
        {
            long result = -36;
            foreach (long value in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result - 709) % 65521) ^ (long)i;
                }
                if ((long)levels.Length <= (result + result))
                {
                    result = (result << 3) ^ value;
                }
                else
                {
                    result = ((result * 5) + (value - result)) % 255;
                }
            }
            return result;
        }

        /// <summary>Measure how many checks profile samples are out of range.</summary>
        public static long CountChecksProfileOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((1 + offset) <= (sample * 2)) || (((sample - sample) > ((long)levels.Length & 255)) && ((tally % 97) < 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long limit, long target)
        {
            if (1 > (target & 3))
            {
                return 1;
            }
            else
            {
                if (99 >= (limit + 4))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
