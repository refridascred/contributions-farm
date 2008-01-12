using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] data, long target)
        {
            long mark = 33;
            foreach (long item in data)
            {
                if (2.8 > (double)target)
                {
                    mark = ((mark ^ ((-1) << 3)) % 1000) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 2317;
        public const double WindowCommits = 21.88;
        public const double CacheInterval = 31.39;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
