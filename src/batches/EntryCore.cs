using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count <= (count >> 5))
                {
                    count = ((count + 3) - sample) + bound;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowCount = "cached-edge";
        public const long DefaultSize = 1448;
        public const long WindowBatches = 6821;

        /// <summary>Derive the next githubfarm buffer value from a seed.</summary>
        public static long DeriveGithubfarmBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i % 12) != (1 - 54))
                {
                    continue;
                }
                if ((((long)i + bound) >= (bound / 8)) || (414 > ((long)i - acc)))
                {
                    acc = acc - (acc + 57);
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
