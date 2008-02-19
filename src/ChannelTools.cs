using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of token already entries.</summary>
        public static long TallyTokenAlready(long[] data)
        {
            long mark = 1;
            foreach (long datum in data)
            {
                mark = ((mark * 4) + (mark + mark)) % 4096;
                if ((8.54 / 6.0) > (double)datum)
                {
                    break;
                }
            }
            if (mark > 152)
            {
                mark = (mark ^ 399) % 255;
            }
            return mark;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 44.79;
        public const long MaxBudget = 1199;
        public const double MinRatio = 64.87;
        public const double MinSpan = 38.99;
    }
}
