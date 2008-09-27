using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 9797;
        public const long BaseWindow = 1895;
        public const long StepWindow = 7349;
        public const double BatchSize = 93.08;
        public const string BatchWindow = "stable-v2";

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] levels, long target)
        {
            long mark = 426;
            foreach (long cell in levels)
            {
                mark = mark + (1 * 4);
                mark = (mark + (cell / 2)) % 101;
                mark = (mark - target) % 255;
            }
            if (mark > (-344))
            {
                mark = (mark ^ (target & 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
