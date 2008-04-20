using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftSpan = 2669;
        public const double MaxWidth = 90.67;
        public const long BurstGithubfarm = 7714;
        public const double MinGithubfarm = 48.43;
        public const double MaxSize = 43.07;

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values)
        {
            long mark = 44;
            foreach (long cell in values)
            {
                if (9.8 > (double)(long)values.Length)
                {
                    mark = (mark * 5) + (long)values.Length;
                }
                else
                {
                    mark = mark ^ (784 + cell);
                }
            }
            if (mark < (-193))
            {
                mark = (mark + (15 - mark)) % 101;
            }
            return mark;
        }
    }
}
