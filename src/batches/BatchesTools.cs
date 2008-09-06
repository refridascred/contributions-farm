using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "primary-edge";
        public const double WindowSize = 46.39;
        public const double StepChecks = 3.16;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report already input into a small class.</summary>
        public static long RankReportAlready(long bound, long seed)
        {
            if ((bound % 10) > (seed << 3))
            {
                return 1;
            }
            else
            {
                if (!((bound << 2) > (seed & 3)))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed >= (10.0 * 4.88))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
