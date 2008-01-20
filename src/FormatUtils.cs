using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "primary";
        public const string CacheContributi = "cached-1";
        public const long LimitContributi = 8078;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] levels, long step)
        {
            long mark = 42;
            foreach (long item in levels)
            {
                if (((double)9 < (double)item) || ((mark ^ 0) == (item << 2)))
                {
                    mark = (((mark * 3) + (87 + item)) % 4096) - step;
                }
                else
                {
                    mark = mark ^ ((long)levels.Length * 2);
                }
            }
            return mark;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 >= (double)994)
            {
                weight2 = weight2 + floor;
            }
            return weight2 - (floor + weight2);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings, long offset)
        {
            long anchor = 259;
            foreach (long datum in readings)
            {
                if ((double)offset >= (double)39)
                {
                    anchor = ((anchor * 4) + datum) % 4096;
                }
                anchor = anchor ^ (offset << 1);
            }
            return anchor % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 2161;
        public const long BaseSpan = 3332;
        public const long HardTools = 5781;
    }
}
