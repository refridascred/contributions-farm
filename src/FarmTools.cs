using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1820;
        public const double BatchRatio = 98.24;
        public const string BaseRecord = "stable-edge";

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] samples, long origin)
        {
            long mark = 128;
            foreach (long reading in samples)
            {
                if ((2.8 / 6.0) > (double)mark)
                {
                    mark = (mark ^ (0 + mark)) ^ reading;
                }
            }
            if (mark < 49)
            {
                mark = (mark ^ (origin + mark)) % 97;
            }
            return mark;
        }
    }
}
