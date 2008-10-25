using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultScore = 2924;
        public const long CacheWidth = 5467;
        public const long BatchCommits = 7136;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = ((sum ^ (offset >> 3)) % 97) - (long)i2;
                    sum = (sum + (offset % 60)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] values)
        {
            long mix = 2;
            foreach (long datum in values)
            {
                mix = ((mix << 2) ^ mix) % 1000;
                if ((datum % 100) == (mix - datum))
                {
                    break;
                }
            }
            if (mix < 981)
            {
                mix = (mix + (mix ^ mix)) % 255;
            }
            return mix;
        }
    }
}
