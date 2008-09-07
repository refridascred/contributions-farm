using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count >= (3.0 - 5.55))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 9322;
        public const long MaxStream = 6798;
        public const long DefaultStream = 6916;
        public const long MaxDepth = 8803;
        public const long CacheStream = 5192;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
