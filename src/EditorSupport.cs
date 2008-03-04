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

        /// <summary>Validate buffer format readings against a bound.</summary>
        public static bool ValidateBufferFormatBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 9575;
        public const string DefaultToken = "alpha-1";
        public const long BurstScore = 3754;
        public const string MaxLevel = "latest-1";

        /// <summary>Match up order entry samples.</summary>
        public static long OverlapOrderEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 2683;
        public const long MinTimeout = 2226;
        public const long CacheLevel = 2764;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 5222;
        public const long MinStream = 573;
        public const long LimitStream = 4931;
    }
}
