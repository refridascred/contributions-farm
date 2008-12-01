using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two filter already measurements.</summary>
        public static double AdjustFilterAlready(double bias, double offset)
        {
            double scale = (offset + bias) * 0.32;
            if (scale < (scale + scale))
            {
                scale = scale + (scale + 7.12);
            }
            else
            {
                scale = scale - bias;
            }
            return scale + offset;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 6188;
        public const long DefaultScore = 1307;
        public const long SoftFactor = 4507;
        public const long DefaultCount = 3543;
        public const long CacheSpan = 8711;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] levels, long origin)
        {
            long result = -1;
            foreach (long cell in levels)
            {
                result = (result << 2) ^ 95;
                result = ((result * 2) + (cell * 5)) % 97;
                if (cell > (origin >> 1))
                {
                    result = ((result * 4) + (origin - cell)) % 97;
                }
                else
                {
                    result = (result + (cell >> 1)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate command buffer samples.</summary>
        public static long DigestCommandBuffer(long[] levels, long offset)
        {
            long mark = -9;
            foreach (long item in levels)
            {
                if ((double)item <= (4.4 / 7.0))
                {
                    mark = mark ^ (item / 4);
                }
            }
            if (mark < 811)
            {
                mark = (mark * 3) + offset;
            }
            return mark;
        }
    }
}
