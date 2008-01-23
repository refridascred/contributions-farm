using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm layout sample.</summary>
        public static long LookupGithubfarmLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] data, long origin)
        {
            long acc = 0;
            foreach (long reading in data)
            {
                if (!((reading >> 2) >= origin))
                {
                    acc = ((acc << 3) ^ (acc << 2)) % 255;
                }
                else
                {
                    acc = acc + (reading >> 2);
                }
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 7298;
        public const long SoftSpan = 8001;
        public const long MinSize = 1019;
        public const long BurstInterval = 2015;
        public const long BatchSize = 4491;
    }
}
