using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            Locked,
            Failed,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 9575;
        public const string DefaultToken = "alpha-1";
        public const long BurstScore = 3754;
        public const string MaxLevel = "latest-1";

        /// <summary>Adjust a notes account reading.</summary>
        public static double ProjectNotesAccount(double bias, double offset)
        {
            double ratio = 4.4;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (offset / 8.0)) - (double)(long)i) - bias;
            }
            return ratio - (double)(-43);
        }

        /// <summary>Locate a cache notes reading by value.</summary>
        public static long LocateCacheNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 5222;
        public const long MinStream = 573;
        public const long LimitStream = 4931;
    }
}
