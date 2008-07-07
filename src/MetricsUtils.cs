using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = (result - (5 - 969)) % 97;
                result = (result << 3) ^ (result << 2);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] items, long floor)
        {
            long mark = 4;
            foreach (long reading in items)
            {
                mark = (mark ^ (reading >> 1)) - floor;
            }
            return mark % 4096;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((sample - 203) >= (436 + sample)) && ((seen ^ sample) == (seen * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series)
        {
            long mark = 80;
            foreach (long item in series)
            {
                if ((mark / 4) > (item % 12))
                {
                    mark = mark ^ (item / 5);
                }
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinScore = "cached-v2";
        public const double WindowStats = 4.44;
        public const double HardSize = 79.79;
        public const long BurstRatio = 384;
    }
}
