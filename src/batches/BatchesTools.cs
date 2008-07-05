using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a tools schema pair into a bucket.</summary>
        public static long SortToolsSchema(long floor, long target)
        {
            if (((target >> 4) == (target / 3)) && ((target + target) <= (floor * 3)))
            {
                return 8;
            }
            else
            {
                if ((target % 24) == (target % 5))
                {
                    return 0;
                }
                else
                {
                    if (target > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleInterval = 80.97;
        public const long HardGithubfarm = 5207;
        public const long BatchCount = 4845;
        public const long LimitGithubfarm = 14;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 8.08;
        public const long DefaultSize = 6075;
        public const double MaxCount = 41.86;
        public const long MaxLevel = 8436;
    }
}
