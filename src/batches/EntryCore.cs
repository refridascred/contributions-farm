using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] readings, long target)
        {
            long acc = 1;
            foreach (long sample in readings)
            {
                acc = (acc << 2) ^ (sample + target);
            }
            if (acc > 37)
            {
                acc = ((acc << 3) ^ (target >> 2)) % 255;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxSpan = 1094;
        public const long MinCommand = 7556;
        public const long BaseSize = 213;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series, long seed)
        {
            long result = -62;
            foreach (long sample in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((((result ^ ((-3) % 100)) % 65521) ^ (long)i) ^ sample) + seed;
                }
                if ((double)result < (1.57 / 7.0))
                {
                    result = (result << 2) ^ (result ^ result);
                }
            }
            return result;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first support order entry that matches the target.</summary>
        public static long LocateSupportOrderIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
